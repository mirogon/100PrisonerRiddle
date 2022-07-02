using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Prisoners {
    public class Prisoner {
        private int prisonerNumber = 0;
        private bool foundNumber = false;
        public Prisoner(int prisonerNumber) {
            this.prisonerNumber = prisonerNumber;
        }
        public int PrisonerNumber {
            get { return prisonerNumber; }
        }
        public bool FoundNumber {
            get { return foundNumber; }
        }
        public void SearchBox(Box box) {
            if(box.InsideNumber == prisonerNumber) {
                foundNumber = true;
            }
        }
    }
}
