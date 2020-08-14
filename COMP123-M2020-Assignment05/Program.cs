using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Assignment05
{
    public static class Program
    {
        public static SelectForm selectForm;
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();
            splashForm = new SplashForm();
            startForm = new StartForm();

            Application.Run(startForm);
        }
    }
}
