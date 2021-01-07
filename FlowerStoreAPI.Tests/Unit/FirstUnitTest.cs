using Xunit;

namespace FlowerStoreAPI.Tests.Unit
{
    public class FirstUnitTest
    {
        [Fact]
        public void TestAddTwoAndTwo()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void TestAddTwoAndSix()
        {
            Assert.Equal(8, Add(2, 6));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}