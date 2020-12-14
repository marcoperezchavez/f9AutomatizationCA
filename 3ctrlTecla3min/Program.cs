using System;
using System.Threading;
using System.Windows.Forms;

namespace _3ctrlTecla3min
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Console.WriteLine("Clickeara 2 veces la tecla control cada 3 minutos");
            for (int i = 0; i < 1000; i++)
            {
               
                Thread.Sleep(30000);
                SendKeys.SendWait("{F9}");
                SendKeys.SendWait("{F9}");
            }
        }
    }
}
