﻿using LLC_TechService_Context;
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
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
            using (var db = new LLCTechServiceContext())
            {
                labelUser.Text = $"{Login.currentUser.SurnameUser} " +
                    $"{Login.currentUser.NameUser} " +
                    $"{Login.currentUser.PatronymicUser} | " +
                    $"{db.Roles.FirstOrDefault(x => x.IdRole == Login.currentUser.RoleUser).TitleRole}";

                var orders = db.Orders.ToList();

                foreach (var order in orders)
                {
                    var status = db.Statuses.FirstOrDefault(x => x.IdStatus == order.StatusOrder);
                    var priority = db.Priorities.FirstOrDefault(x => x.IdPriority == order.PriorityOrder);
                    var equipment = db.Equipment.FirstOrDefault(x => x.IdEquipment == order.EquipmentOrder);
                    var client = db.Users.FirstOrDefault(x => x.IdUser == order.ClientOrder);
                    var master = db.Users.FirstOrDefault(x => x.IdUser == order.MasterOrder);

                    var orderView = new OrderView(order, status, priority, equipment, client, master);

                    orderView.Parent = flowLayoutPanel1;

                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var create = new CreateOrder();
            create.Show();
        }
    }
}
