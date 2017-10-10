using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundConsoleTest
{
    class ConsoleOutput
    {
        /// <summary>
        /// 获取或设置控制台是否有效。
        /// </summary>
        public static bool ConsoleEnabled { get; set; }


        public static void ShowDebug(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowInfomation(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowWarning(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowError(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowFatal(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                var backgroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowDebugLine(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowInfomationLine(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowWarningLine(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowErrorLine(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowFatalLine(string message)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                var backgroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }
        public static void ShowDebug(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowInfomation(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowWarning(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowError(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowFatal(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                var backgroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(format, args);
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowDebugLine(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowInfomationLine(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowWarningLine(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowErrorLine(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(format, args);
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }

        public static void ShowFatalLine(string format, params object[] args)
        {
            if (!ConsoleEnabled)
            {
                return;
            }
            try
            {
                var foregroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                var backgroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(format, args);
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
            }
            catch
            {
                //do nothing
            }
        }
    }
}
