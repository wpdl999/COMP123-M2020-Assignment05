using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Author's name : Wooram Moon
    Author's student Number : 301098673
    Date last Modified : 
    Program description
    1st Revision : Aug 10th
    2nd Revision : Aug 12th
    3rd Revision : Aug 13th
    4th Revision : Aug 15th
    5th Revision : Aug 18th
 */
namespace COMP123_M2020_Assignment05
{
    public static class Program
    {
        public static SelectForm selectForm;
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static Products selectProducts;
        public static AboutBoxForm aboutBoxForm;

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
            orderForm = new OrderForm();
            selectProducts = new Products();
            aboutBoxForm = new AboutBoxForm();

            Application.Run(splashForm);
        }
    }
}
