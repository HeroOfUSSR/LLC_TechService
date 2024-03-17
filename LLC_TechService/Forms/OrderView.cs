using LLC_TechService_Context;
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

            this.viewOrder = order;
            this.viewClient = client;
            this.viewMaster = master;
            this.viewEquip = equipment;
            this.viewMalfunction = malfunction;
            this.viewStatus = status;
            this.viewPriority = priority;

            Init_View(order, status, priority, equipment, client, master, malfunction);
        }


        private void Init_View(Order order, Status status, 
            Priority priority, Equipment equipment, 
            User client, User master, Malfunction malfunction)
        {
            using (var db = new LLCTechServiceContext())
            {
                labelID.Text = $"Заказ №{order.IdOrder}";
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
                labelProblem.Text = malfunction.NameMalfunction;

                if (Login.currentUser.RoleUser == 3)
                {
                    buttonEdit.Visible = false;
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
    }
}
