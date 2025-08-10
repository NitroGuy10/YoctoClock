using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace YoctoClock
{
    [StructLayout(LayoutKind.Sequential)]
    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        public IntPtr lpData;
    }


    static class Program
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public const int WM_COPYDATA = 0x004A;

        public const string HiddenWindowTitle = "YoctoClockHiddenWindow";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = false;
            using (Mutex mutex = new Mutex(true, "YoctoClockMutex", out createdNew))
            {
                if (createdNew)
                {
                    // Open application
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MainForm mainForm = new MainForm();


                    using (HiddenMessageWindow messageWindow = new HiddenMessageWindow(mainForm))
                    {
                        Application.Run(mainForm);
                    }
                }
                else
                {
                    // Send a message to the existing instance, telling it to focus itself
                    IntPtr hWnd = FindWindow(null, HiddenWindowTitle);


                    if (hWnd != IntPtr.Zero)
                    {
                        const string command = "focus";
                        IntPtr dataPtr = Marshal.StringToHGlobalUni(command);
                        try
                        {
                            COPYDATASTRUCT cds = new COPYDATASTRUCT
                            {
                                dwData = IntPtr.Zero,  // Unused
                                cbData = (command.Length + 1) * sizeof(char),
                                lpData = dataPtr
                            };

                            SendMessage(hWnd, WM_COPYDATA, IntPtr.Zero, ref cds);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Failed sending data: " + ex.ToString(), "Second Instance");
                        }
                        finally
                        {
                            Marshal.FreeHGlobal(dataPtr);
                        }
                    }
                }
            }
        }
    }
}
