using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseMover
{
    /// <summary>
    /// Static class which containts Windows API methodds
    /// </summary>
    public static class MouseHelper
    {
        /// <summary>
        /// Windows API method for moving mouse coursor to specific point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);
    }
}
