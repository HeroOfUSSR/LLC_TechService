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
    public partial class Login : Form
    {
        public static User currentUser { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new LLCTechServiceContext())
            {
                var login = logintextBox.Text;
                var password = passwordtextBox.Text;

                currentUser = db.Users.FirstOrDefault(x => x.LoginUser == login && x.PasswordUser == password);

                if (currentUser != null)
                {
                    var orderForm = new Orders();
                    var clientForm = new ClientMenu();

                    switch (currentUser.RoleUser)
                    {
                        case 1:
                            orderForm.Show();
                            break;

                        case 2:
                            orderForm.Show();
                            break;
                        case 3:
                            clientForm.Show();
                            break;
                    }

                }
                else MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reg = new Registration();
            reg.Show();
        }
    }
}
