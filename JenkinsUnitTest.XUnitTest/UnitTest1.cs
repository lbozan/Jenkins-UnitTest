using JenkinsUnitTest.App;
using Xunit;


namespace JenkinsUnitTest.XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("This is Jenkins Test", Program.CreateMessage());
        }
    }
}
