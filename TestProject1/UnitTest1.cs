using Xunit;
using LengthCalculater;

namespace XunitTest
{
    public class UnitTest1
    {
        LengthHelper stringLength = new LengthHelper();

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(7, stringLength.findLength("Naveena"));

            Assert.Equal(3, stringLength.findLength("123"));
            Assert.Equal(0, stringLength.findLength(""));
            Assert.Equal(12, stringLength.findLength("123456789010"));
            Assert.Equal(4, stringLength.findLength("NULL"));

        }
    }
}
