using NUnit.Framework;
using Themis.Specs.Infrastructure;
using White.Core.WindowsAPI;

namespace Themis.Specs
{
    [TestFixture]
    public class SampleTest : TestBase
    {
        [Test]
        public void InconclusiveTest()
        {
            Window.PressShortcut('f', KeyboardInput.SpecialKeys.ALT);
            Window.PressShortcut('n');
            Assert.Inconclusive();
        }
    }
}