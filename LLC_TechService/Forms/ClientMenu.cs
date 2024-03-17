using LLC_TechService_Context;
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
    public partial class ClientMenu : Form
    {
        public ClientMenu()
        {
            InitializeComponent();
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            Init_Grid();
        }

        private void Init_Grid()
        {
            using (var db = new LLCTechServiceContext())
            {
                labelClient.Text = $"{Login.currentUser.SurnameUser} " +
                    $"{Login.currentUser.NameUser} " +
                    $"{Login.currentUser.PatronymicUser}";

                var orders = db.Orders.Where(x => x.ClientOrder == Login.currentUser.IdUser).ToList();

                foreach (var order in orders)
                {
                    var status = db.Statuses.FirstOrDefault(x => x.IdStatus == order.StatusOrder);
                    var priority = db.Priorities.FirstOrDefault(x => x.IdPriority == order.PriorityOrder);
                    var equipment = db.Equipment.FirstOrDefault(x => x.IdEquipment == order.EquipmentOrder);
                    var client = db.Users.FirstOrDefault(x => x.IdUser == order.ClientOrder);
                    var master = db.Users.FirstOrDefault(x => x.IdUser == order.MasterOrder);
                    var malfunction = db.Malfunctions.FirstOrDefault(x => x.IdMalfunction == order.MalfunctionOrder);

                    var orderView = new OrderView(order, status, priority, equipment, client, master, malfunction);

                    orderView.Parent = flowLayoutPanel1;
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var create = new CreateOrder();
            create.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Init_Grid();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }
    }
}
