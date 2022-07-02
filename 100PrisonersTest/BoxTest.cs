using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using _100Prisoners;

namespace _100PrisonersTest {
    public class BoxTest {
        [Fact]
        public void OutsideNumber_EqualsGiven() {
            Box b = new Box(55, 1);
            Assert.Equal(55, b.OutsideNumber);

            b = new Box(11, 0);
            Assert.Equal(11, b.OutsideNumber);
        }
        [Fact]
        public void InsideNumber_EqualsGiven() {
            Box b = new Box(0, 99);
            Assert.Equal(99, b.InsideNumber);
        }
    }
}
