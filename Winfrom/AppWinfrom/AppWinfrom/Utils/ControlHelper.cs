using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public static class ControlHelper
    {
        public static void ThreadSafeCall(this Control control, Action method)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(method);
            }
            else
            {
                method();
            }
        }

        public static T ThreadSafeCall<T>(this Control control, Func<T> method)
        {
            if (control.InvokeRequired)
            {
                return (T)control.Invoke(method);
            }

            return method();
        }
    }
}
