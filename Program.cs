using CheatCracker;
using System;
using System.Windows.Forms;

namespace LarpCity
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            
            Splash splash = new Splash();
            splash.Show();          
            Application.DoEvents(); 

            System.Threading.Thread.Sleep(5000); 

            splash.Close();         

            
            Application.Run(new Form1());
        }
    }
}
