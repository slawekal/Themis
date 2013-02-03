using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Automation;
using White.Core.UIItems.WindowItems;
using White.Core.WindowsAPI;

namespace Themis.Specs.Infrastructure
{
    internal static class Extensions
    {
        private const int SLEEP_AFTER_CLICK = 100;

        public static void PressShortcut(
            this Window window, char key, params KeyboardInput.SpecialKeys[] specialKeys)
        {
            var specialKeysList = specialKeys.ToList();
            specialKeysList.ForEach(specialKey => window.Keyboard.HoldKey(specialKey));
            window.Keyboard.Enter(key.ToString(CultureInfo.InvariantCulture));
            specialKeysList.ForEach(specialKey => window.Keyboard.LeaveKey(specialKey));
            Thread.Sleep(SLEEP_AFTER_CLICK);
        }

        public static char ToChar(this KeyboardInput.SpecialKeys specialKey)
        {
            return (char) specialKey;
        }

        public static void Click(this AutomationElement element)
        {
            ApplicationWrapper.Instance.Window.Mouse.Click(element.GetClickablePoint());
            Thread.Sleep(SLEEP_AFTER_CLICK);
        }
    }
}