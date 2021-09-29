using System;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Form1 lf = new Form1();
            lf.ShowDialog();
            if (lf.DialogResult== DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}