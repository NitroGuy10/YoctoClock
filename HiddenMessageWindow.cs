using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoctoClock
{
    // Hidden window that receives messages
    public class HiddenMessageWindow : NativeWindow, IDisposable
    {
        private MainForm mainForm;

        public HiddenMessageWindow(MainForm mainForm)
        {
            this.mainForm = mainForm;

            CreateParams cp = new CreateParams
            {
                Caption = Program.HiddenWindowTitle,
                X = 0,
                Y = 0,
                Height = 100,
                Width = 100,
                //Style = 0x10000000
                Style = unchecked((int)0x80000000) // WS_POPUP (invisible)
            };
            CreateHandle(cp);

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Program.WM_COPYDATA)
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                string message = Marshal.PtrToStringUni(cds.lpData);
                HandleMessage(message);
            }
            base.WndProc(ref m);
        }

        private void HandleMessage(string message)
        {
            if (message == "focus")
            {
                mainForm.ShowApplication();
            }
        }

        public void Dispose()
        {
            DestroyHandle();
        }
    }
}
