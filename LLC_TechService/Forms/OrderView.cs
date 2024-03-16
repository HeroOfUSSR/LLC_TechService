using LLC_TechService_Context;
using LLC_TechService_Context.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = LLC_TechService_Context.Models.User;

namespace LLC_TechService.Forms
{
    public partial class OrderView : UserControl
    {
        public OrderView(Order order, Status status, Priority priority, Equipment equipment, User client, User master)
        {
            InitializeComponent();
            Init_View(order, status, priority, equipment, client, master);
        }
        

        private void Init_View(Order order, Status status, Priority priority, Equipment equipment, User client, User master)
        {
            using (var db = new LLCTechServiceContext())
            {
                labelID.Text = $"Заказ №{order.IdOrder}";
                labelEquip.Text = $"{equipment.NameEquipment}";
                labelClient.Text = $"Клиент: {client.SurnameUser} {client.NameUser} {client.PatronymicUser}";
                labelMaster.Text = $"Мастер: {master.SurnameUser} {master.NameUser} {master.PatronymicUser}";
                labelPriority.Text = $"Приоритет: {priority.NamePriority}";
                labelStatus.Text = $"Статус: {status.NameStatus}";

                if (Login.currentUser.RoleUser != 1)
                {
                    buttonEdit.Visible = false;
                }
            }
        }
    }
}
