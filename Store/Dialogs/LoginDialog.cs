using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            Person.CreateUser(txtLogin.Text);
            if (Person.CurrUser.ErrCode == ErrCode.ErrNoData)
            {
                MessageBox.Show("Указан неверный логин.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Person.CurrUser.ErrCode != ErrCode.ErrOK)
            {
                MessageBox.Show("Ошибка обращения к БД: " + Person.CurrUser.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Person.CurrUser.CheckPassword(txtPassword.Text))
            {
                MessageBox.Show("Указан неверный пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
