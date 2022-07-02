using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Prisoners {
    public class Box {
        private int outsideNumber = 0;
        private int insideNumber = 0;
        public Box(int outsideNumber, int insideNumber) {
            this.outsideNumber = outsideNumber;
            this.insideNumber = insideNumber;
        }
        public int OutsideNumber {
            get { return outsideNumber; }
        }
        public int InsideNumber {
            get { return insideNumber; }
        }
    }
}
