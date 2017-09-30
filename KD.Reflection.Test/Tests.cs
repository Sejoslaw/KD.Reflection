using Xunit;

namespace KD.Reflection.Tests
{
    public class Tests
    {
        [Fact]
        public void Test_if_reflection_worked()
        {
            var test = new TestClass();
            test.CallMethod<object>("PrintHello");
        }
    }
}