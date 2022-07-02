using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Prisoners {
    public class Boxes {
        private Box[] boxList;
        public Boxes(int numberOfBoxes) {
            boxList = new Box[numberOfBoxes];

            List<int> insideNumberPool = new List<int>();
            for(int i = 1; i <= numberOfBoxes; ++i) {
                insideNumberPool.Add(i);
            }

            for(int i = 0; i < numberOfBoxes; ++i) {
                Random random = new Random();
                int index = random.Next(insideNumberPool.Count);
                int insideNumber = insideNumberPool[index];
                insideNumberPool.RemoveAt(index);

                boxList[i] = new Box(i + 1, insideNumber);
            }
        }
        public Box[] BoxList {
            get { return boxList; }
        }
    }
}
