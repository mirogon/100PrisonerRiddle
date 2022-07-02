using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Prisoners {
    public class RiddleSolver {
        private int numPrisoners = 100;
        private Prisoner[] prisoners;
        private Boxes boxes;
        public RiddleSolver(int numPrisoners) {
            this.numPrisoners = numPrisoners;
            prisoners = new Prisoner[this.numPrisoners];
            for (int i = 0; i < this.numPrisoners; i++) {
                prisoners[i] = new Prisoner(i + 1);
            }
            boxes = new Boxes(numPrisoners);
        }
        public bool SolveRandom() {
            for(int i = 0; i < numPrisoners; ++i) {
                if (OnePrisonerRandomSearch(prisoners[i], boxes.BoxList) == false) {
                    return false;
                }
            }
            return true;
        }
        public bool SolveCircle() {
            for(int i = 0; i < numPrisoners; ++i) {
                if (OnePrisonerCircleSearch(prisoners[i], boxes.BoxList) == false) {
                    return false;
                }
            }
            return true;
        }
        private bool OnePrisonerRandomSearch(Prisoner p, Box[] boxes) {
            bool foundBox = false;
            List<int> availableBoxes = new List<int>();
            for(int i = 0; i < boxes.Length; ++i) {
                availableBoxes.Add(i);
            }

            for(int i = 0; i < numPrisoners/2; ++i) {
                Random r = new Random();
                int availableBoxesIndex = r.Next(availableBoxes.Count);
                int boxIndex = availableBoxes[availableBoxesIndex];
                availableBoxes.RemoveAt(availableBoxesIndex);

                if (boxes[boxIndex].InsideNumber == p.PrisonerNumber) {
                    foundBox = true;
                }
            }
            return foundBox;
        }
        private bool OnePrisonerCircleSearch(Prisoner p, Box[] boxes) {
            int boxToSearch = p.PrisonerNumber;

            for(int i = 0; i < numPrisoners /2; ++i) {
                Box? b = null;
                for(int j = 0; j < boxes.Length; ++j) {
                    if (boxes[j].OutsideNumber == boxToSearch) {
                        b = boxes[j];
                    }
                }
                if(b.InsideNumber == p.PrisonerNumber) {
                    return true;
                }
                boxToSearch = b.InsideNumber;
            }
            return false;
        }

    }
}
