using System.Globalization;
using System.Linq;
using System.Threading;
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
    }
}