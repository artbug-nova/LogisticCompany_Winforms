using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Store
{
    static class Program
    {
        public static MDIForm mdiForm = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginDialog dialog = new LoginDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mdiForm = new MDIForm();
                Application.Run(mdiForm);
            }
            //if (dialog.DialogResult == DialogResult.OK) Application.Run(new MDIForm());
        }
    }
}
