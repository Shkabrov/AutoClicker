using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 121)//F10
                    {
                        buttonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113)//F2
                    {
                        buttonStart.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 115)//F4
                    {
                        buttonPickLocation.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 120)//F9
                    {
                        buttonInfinityClick.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                m_callback,
                GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //Для определения позиции курсора
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixels = 0;
        static protected int diffX;
        static protected int diffY;
        static public bool isStart = false;

        //Нормированные абсолютные координаты
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //Нажатие на левую кнопку мыши
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //Поднятие левой кнопки мыши
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        //Нажатие на правой кнопку мыши
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //Поднятие правой кнопки мыши
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //перемещение указателя мыши
        private const int MOUSEEVENTF_MOVE = 0x0001;

        public AutoClicker()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
        }
        private void AutoClicker_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        async private void buttonStart_Click(object sender, EventArgs e)
        {
            isStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int X = 65535 / resolution.Width * Convert.ToInt32(textBoxForX.Text);
            int Y = 65535 / resolution.Height * Convert.ToInt32(textBoxForY.Text);

            while (isStart)
            {
                if (buttonOne.Checked == true && buttonLeft.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (buttonDouble.Checked == true && buttonLeft.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (buttonOne.Checked == true && buttonRight.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                if (buttonDouble.Checked == true && buttonRight.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                await Task.Delay(Convert.ToInt32(textBoxForMilSecs.Text) + 1000 * Convert.ToInt32(textBoxForSecs.Text));
            }
        }

        //Кнопка закрытия приложения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка сворачивания приложения
        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            isStart = false;
            textBoxForMilSecs.Text = "40";
            textBoxForSecs.Text = "0";
            textBoxForX.Text = "0";
            textBoxForY.Text = "0";
        }

        private void textBoxForMilSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if(!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBoxForSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        //Функция определения позиции курсора
        private void buttonPickLocation_Click(object sender, EventArgs e)
        {
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            textBoxForX.Text = defPnt.X.ToString();
            textBoxForY.Text = defPnt.Y.ToString();
        }

        async private void buttonInfinityClick_Click(object sender, EventArgs e)
        {
            isStart = true;

            int X = lastPoint.X;
            int Y = lastPoint.Y;

            while (isStart)
            {
                if (buttonOne.Checked == true && buttonLeft.Checked == true)
                {
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (buttonDouble.Checked == true && buttonLeft.Checked == true)
                {
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (buttonOne.Checked == true && buttonRight.Checked == true)
                {
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                if (buttonDouble.Checked == true && buttonRight.Checked == true)
                {
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                await Task.Delay(Convert.ToInt32(textBoxForMilSecs.Text) + 1000 * Convert.ToInt32(textBoxForSecs.Text));
            }
        }

        /* private void textBoxForSecs_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
         {
             if (Keyboard.IsKeyDown(Key.Back) && textBoxForSecs.Text.Length > 0)
             {
                 textBoxForSecs.Text = textBoxForSecs.Text.Substring(0, textBoxForSecs.Text.Length - 1);
             }
         }*/

        /*private void textBoxForMilSecs_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Back) && textBoxForMilSecs.Text.Length > 0)
            {
                textBoxForMilSecs.Text = textBoxForMilSecs.Text.Substring(0, textBoxForMilSecs.Text.Length - 1);
            }
        }*/
    }
}
