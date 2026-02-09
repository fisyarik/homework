using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinAnim
{
    public class WinAPIClass
    {
        [Flags]
        public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,    // Слева направо
            AW_HOR_NEGATIVE = 2,    // Справа налево
            AW_VER_POSITIVE = 4,    // Сверху вниз
            AW_VER_NEGATIVE = 8,    // Снизу вверх
            AW_CENTER = 16,         // Из центра
            AW_HIDE = 65536,        // Скрыть окно
            AW_ACTIVATE = 131072,   // Активировать окно
            AW_SLIDE = 262144,      // Использовать скольжение
            AW_BLEND = 524288       // Использовать плавное затухание (fading)
        };

        // Импорт функции AnimateWindow из системной библиотеки user32.dll
        [DllImport("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        // Перегруженный метод для удобства работы с объектами Control
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
    }
}