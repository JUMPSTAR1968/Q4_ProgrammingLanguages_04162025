using System;
using System.Windows.Forms;
using StudentDetailsApp;

namespace Q4_ProgrammingLanguages_04162025
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
