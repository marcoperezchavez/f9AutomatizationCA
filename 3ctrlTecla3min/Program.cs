using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _3ctrlTecla3min
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
        [STAThread]
        static void Main(string[] args)
        {
            AllocConsole();
            Console.WriteLine("Clickeara 2 veces la tecla F9 cada 3 minutos");
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Ciclo {i+1}");
                Thread.Sleep(30000);
                SendKeys.SendWait("{F9}");
                SendKeys.SendWait("{F9}");
            }
        }
    }
}
