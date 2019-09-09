using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ex02_Othelo
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSetting gameSettingForm = new FormSetting();
            Application.Run(gameSettingForm);
        }
    }
}
