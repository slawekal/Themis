using Themis.Specs.Infrastructure;
using White.Core;
using White.Core.UIItems.WindowItems;

namespace Themis.Specs
{
    public class TestBase
    {
        protected static Application Application
        {
            get { return ApplicationWrapper.Instance.Application; }
        }

        protected static Window Window
        {
            get { return ApplicationWrapper.Instance.Window; }
        }
    }
}