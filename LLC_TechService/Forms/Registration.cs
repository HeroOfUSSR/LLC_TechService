using LLC_TechService_Context;
using LLC_TechService_Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLC_TechService.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPatronimyc.Text == "" ||
                textBoxSurname.Text == "" || textBoxLogin.Text == "" ||
                textBoxPassword.Text == "" || textBoxRepeat.Text == "") MessageBox.Show("Все поля обязательны к заполнению");
            else
            {
                if (textBoxPassword.Text == textBoxRepeat.Text)
                {
                    using (var db = new LLCTechServiceContext())
                    {
                        User newUser = new User
                        {
                            NameUser = textBoxName.Text,
                            SurnameUser = textBoxSurname.Text,
                            PatronymicUser = textBoxPatronimyc.Text,
                            LoginUser = textBoxLogin.Text,
                            PasswordUser = textBoxPassword.Text,
                            RoleUser = 3
                        };

                        db.Users.Add(newUser);
                        db.SaveChanges();

                        MessageBox.Show("Аккаунт успешно создан");
                        this.Close();
                    }
                }
                else MessageBox.Show("Пароли не совпадают");
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
