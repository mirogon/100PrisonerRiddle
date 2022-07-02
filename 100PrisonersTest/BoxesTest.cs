using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using _100Prisoners;
namespace _100PrisonersTest {
    public class BoxesTest {
        [Fact]
        public void AfterCreation_OnlyUniqueBoxes() {
            Boxes boxes = new Boxes(100);
            Assert.Equal(100, boxes.BoxList.Length);

            for(int i = 0; i < boxes.BoxList.Length; ++i) {
                int currentNum = boxes.BoxList[i].InsideNumber;
                bool duplicate = false;
                
                for(int j = 0; j < boxes.BoxList.Length; ++j) {
                    if(currentNum == boxes.BoxList[j].InsideNumber && i != j) {
                        duplicate = true;
                    }
                }

                Assert.Equal(i + 1, boxes.BoxList[i].OutsideNumber);
                Assert.False(duplicate);
            }
        }
    }
}
