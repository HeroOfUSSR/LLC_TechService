using LLC_TechService_Context;
using LLC_TechService_Context.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Orders : Form
    {
        private decimal sum;
        public Orders()
        {
            InitializeComponent();

            comboStatus.DisplayMember = nameof(Status.NameStatus);
            comboStatus.ValueMember = nameof(Status.IdStatus);
            comboPriority.DisplayMember = nameof(Priority.NamePriority);
            comboPriority.ValueMember = nameof(Priority.IdPriority);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            Init_Grid();
        }

        private void Init_Grid()
        {
            using (var db = new LLCTechServiceContext())
            {
                labelUser.Text = $"{Login.currentUser.SurnameUser} " +
                    $"{Login.currentUser.NameUser} " +
                    $"{Login.currentUser.PatronymicUser} | " +
                    $"{db.Roles.FirstOrDefault(x => x.IdRole == Login.currentUser.RoleUser).TitleRole}";

                comboStatus.Items.AddRange(db.Statuses
                    .OrderBy(x => x.IdStatus).ToArray());
                comboPriority.Items.AddRange(db.Priorities
                    .OrderBy(x => x.IdPriority).ToArray());

                comboStatus.Items.Insert(0, new Status()
                {
                    IdStatus = 0,
                    NameStatus = "Все статусы"
                });
                comboPriority.Items.Insert(0, new Priority()
                {
                    IdPriority = 0,
                    NamePriority = "Все приоритеты"
                });

                comboStatus.SelectedIndex = 0;
                comboPriority.SelectedIndex = 0;

                List<Order> orders;

                if (Login.currentUser.RoleUser == 1) orders = db.Orders
                        .OrderByDescending(x => x.StatusOrder)
                        .ThenBy(x => x.PriorityOrder).ToList();
                else orders = db.Orders
                        .OrderByDescending(x => x.StatusOrder)
                        .ThenBy(x => x.PriorityOrder)
                        .Where(x => x.MasterOrder == Login.currentUser.IdUser).ToList();

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
                CountSpends();
            }
        }

        private void CountSpends()
        {
            using (var db = new LLCTechServiceContext())
            {
                if (Login.currentUser.RoleUser == 1)
                    sum = db.Reports.Sum(x => x.CostReport);
                else
                    sum = db.Reports
                        .Where(x => x.MasterReport == Login.currentUser.IdUser)
                        .Sum(x => x.CostReport);

                labelSpends.Text = $"Общие траты: {sum} руб";
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var create = new CreateOrder();
            create.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Init_Grid();
            Sort();
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            var addPart = new AddParts();
            addPart.ShowDialog();
        }

        private void Sort()
        {
            if (comboPriority.SelectedItem == null || comboStatus.SelectedItem == null) return;

            var selectedPrio = ((Priority)comboPriority.SelectedItem).IdPriority;
            var selectedStatus = ((Status)comboStatus.SelectedItem).IdStatus;

            foreach (var item in flowLayoutPanel1.Controls)
            {
                var visible = true;
                if (item is OrderView orderView)
                {
                    if (selectedPrio != 0 && !(orderView.Order.PriorityOrder == selectedPrio))
                    {
                        visible = false;
                    }

                    if (selectedStatus != 0 && !(orderView.Order.StatusOrder == selectedStatus))
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        orderView.Order.IdOrder.CompareTo(Convert.ToInt32(textBoxSearch.Text)) == 0))
                    {
                        visible = false;
                    }

                    orderView.Visible = visible;
                }
            }

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void comboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Sort();
        }

  
    }
}
