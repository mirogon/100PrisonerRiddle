using Xunit;
using _100Prisoners;

namespace _100PrisonersTest {
    public class PrisonerTest {
        [Fact]
        public void PrisonerNumber_EqualsGiven() {
            Prisoner p = new Prisoner(1);
            Assert.Equal(1, p.PrisonerNumber);

            p = new Prisoner(100);
            Assert.Equal(100, p.PrisonerNumber);
        }
        [Fact]
        public void SearchBox_WithWrongNumber_FoundNumberIsFalse() {
            Prisoner p = new Prisoner(5);
            Box b = new Box(5, 1);
            p.SearchBox(b);
            Assert.False(p.FoundNumber);

            b = new Box(1, 5);
            p.SearchBox(b);
            Assert.True(p.FoundNumber);
        }
    }
}