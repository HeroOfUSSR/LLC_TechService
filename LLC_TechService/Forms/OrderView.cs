﻿using LLC_TechService_Context;
using LLC_TechService_Context.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = LLC_TechService_Context.Models.Status;
using User = LLC_TechService_Context.Models.User;

namespace LLC_TechService.Forms
{
    public partial class OrderView : UserControl
    {
        private readonly Order viewOrder;
        private readonly User viewClient;
        private readonly User viewMaster;
        private readonly Equipment viewEquip;
        private readonly Malfunction viewMalfunction;
        private readonly Status viewStatus;
        private readonly Priority viewPriority;

        public OrderView(Order order, Status status,
            Priority priority, Equipment equipment,
            User client, User master, Malfunction malfunction)
        {
            InitializeComponent();

            viewOrder = order;
            viewClient = client;
            viewMaster = master;
            viewEquip = equipment;
            viewMalfunction = malfunction;
            viewStatus = status;
            viewPriority = priority;

            Init_View(order, status, priority, equipment, client, master, malfunction);
        }

        public Order Order => viewOrder;
        public Equipment Equip => viewEquip;
        private void Init_View(Order order, Status status,
            Priority priority, Equipment equipment,
            User client, User master, Malfunction malfunction)
        {
            using (var db = new LLCTechServiceContext())
            {
                if (order.DoneDateOrder != null)
                {
                    if (DateTime.Compare((DateTime)order.DoneDateOrder, DateTime.Now) < 0)
                    {
                        labelID.Text = $"Заказ №{order.IdOrder}  | Просрочен";
                        labelID.ForeColor = Color.Red;
                    }    
                    else labelID.Text = $"Заказ №{order.IdOrder}";
                }
                else labelID.Text = $"Заказ №{order.IdOrder}";
                labelEquip.Text = $"{equipment.NameEquipment}";
                labelClient.Text = $"Клиент: {client.SurnameUser} " +
                    $"{client.NameUser} " +
                    $"{client.PatronymicUser}";
                if (master != null) labelMaster.Text = $"Мастер: {master.SurnameUser} " +
                        $"{master.NameUser} " +
                        $"{master.PatronymicUser}";
                else labelMaster.Text = $"Мастер не назначен";
                labelPriority.Text = $"Приоритет: {priority.NamePriority}";
                labelStatus.Text = $"Статус: {status.NameStatus}";
                if (order.DescOrder == null || order.DescOrder == "") labelDesc.Visible = false;
                labelDesc.Text = order.DescOrder;
                labelProblem.Text = malfunction.NameMalfunction;

                if (Login.currentUser.RoleUser == 3)
                {
                    buttonEdit.Visible = false;
                    buttonDone.Visible = false;
                    labelPriority.Visible = false;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editOrder = new EditOrder(viewOrder, viewStatus, viewPriority,
                viewEquip, viewClient, viewMaster, viewMalfunction);
            editOrder.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var createReport = new CreateReport(viewOrder);
            createReport.ShowDialog();
        }
    }
}
