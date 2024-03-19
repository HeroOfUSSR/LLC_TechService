using LLC_TechService_Context.Models;
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
    public partial class EditOrder : Form
    {
        private readonly Order _order;
        private readonly Equipment _equip;
        private readonly Malfunction _malfunction;

        public EditOrder(Order order, Status status, Priority priority, Equipment equipment, User client, User master, Malfunction malfunction)
        {
            InitializeComponent();
            textBoxEquip.Text = equipment.NameEquipment;
            textBoxSerial.Text = $"{equipment.SerialEquipment}";
            textBoxDesc.Text = order.DescOrder;
            textBoxProblem.Text = malfunction.NameMalfunction;

            using (var db = new LLCTechServiceContext())
            {
                comboType.DisplayMember = nameof(EquipmentType.NameEquipType);
                comboType.ValueMember = nameof(EquipmentType.IdEquipType);
                comboStatus.DisplayMember = nameof(Status.NameStatus);
                comboStatus.ValueMember = nameof(Status.IdStatus);
                comboPriority.DisplayMember = nameof(Priority.NamePriority);
                comboPriority.ValueMember = nameof(Priority.IdPriority);

                comboMaster.DisplayMember = nameof(User.SurnameUser);
                comboMaster.ValueMember = nameof(User.IdUser);
                comboClient.DisplayMember =nameof(User.SurnameUser);
                comboClient.ValueMember = nameof(User.IdUser);

                comboMaster.Items.AddRange(db.Users.OrderBy(x => x.IdUser).Where(x => x.RoleUser == 2).ToArray());
                comboClient.Items.AddRange(db.Users.OrderBy(x => x.IdUser).Where(x => x.RoleUser == 3).ToArray());
                comboStatus.Items.AddRange(db.Statuses.OrderBy(x => x.IdStatus).ToArray());
                comboPriority.Items.AddRange(db.Priorities.OrderBy(x => x.IdPriority).ToArray());
                comboType.Items.AddRange(db.EquipmentTypes.OrderBy(x => x.IdEquipType).ToArray());


                comboStatus.SelectedItem = comboStatus.Items.Cast<Status>()
                    .FirstOrDefault(x => x.IdStatus == status.IdStatus);
                if (master != null) comboMaster.SelectedItem = comboMaster.Items.Cast<User>()
                    .FirstOrDefault(x => x.IdUser == master.IdUser);
                comboClient.SelectedItem = comboClient.Items.Cast<User>()
                    .FirstOrDefault(x => x.IdUser == client.IdUser);
                comboType.SelectedItem = comboType.Items.Cast<EquipmentType>()
                    .FirstOrDefault(x => x.IdEquipType == equipment.TypeEquipment);
                comboPriority.SelectedItem = comboPriority.Items.Cast<Priority>()
                    .FirstOrDefault(x => x.IdPriority == priority.IdPriority);

                this._order = order;
                this._equip = equipment;
                this._malfunction = malfunction;
            }
        }


        private void EditOrder_Load(object sender, EventArgs e)
        {
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxEquip.Text != "" || textBoxSerial.Text != ""
                || textBoxProblem.Text != "")
            {
                using (var db = new LLCTechServiceContext())
                {
                    var editProblem = db.Malfunctions.FirstOrDefault(x => x.IdMalfunction == _malfunction.IdMalfunction);
                    editProblem.NameMalfunction = textBoxProblem.Text;


                    var editEquip = db.Equipment.FirstOrDefault(x => x.IdEquipment == _equip.IdEquipment);

                    editEquip.NameEquipment = textBoxEquip.Text;
                    editEquip.SerialEquipment = Convert.ToInt32(textBoxSerial.Text);
                    editEquip.TypeEquipment = ((EquipmentType)comboType.SelectedItem).IdEquipType;

                    db.Malfunctions.Update(editProblem);
                    db.Equipment.Update(editEquip);

                    db.SaveChanges();

                    var editOrder = db.Orders.FirstOrDefault(x => x.IdOrder == _order.IdOrder);

                    editOrder.EquipmentOrder = _equip.IdEquipment;
                    editOrder.DescOrder = textBoxDesc.Text;
                    editOrder.MalfunctionOrder = _malfunction.IdMalfunction;
                    editOrder.ClientOrder = ((User)comboClient.SelectedItem).IdUser;
                    editOrder.StatusOrder = ((Status)comboStatus.SelectedItem).IdStatus;
                    editOrder.PriorityOrder = ((Priority)comboPriority.SelectedItem).IdPriority;
                    editOrder.MasterOrder = ((User)comboMaster.SelectedItem).IdUser;
                    editOrder.DoneDateOrder = dateTimePicker.Value;

                    db.Orders.Update(editOrder);

                    db.SaveChanges();

                    MessageBox.Show("Заказ изменён");
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Введите данные во все поля со звёздочкой");
            }
            
        }

        private void comboMaster_Format(object sender, ListControlConvertEventArgs e)
        {
            string surname = ((User)e.ListItem).SurnameUser;
            string name = ((User)e.ListItem).NameUser;
            string patronimyc = ((User)e.ListItem).PatronymicUser;
            e.Value = surname + " " + name + " " + patronimyc;
        }

        private void comboClient_Format(object sender, ListControlConvertEventArgs e)
        {
            string surname = ((User)e.ListItem).SurnameUser;
            string name = ((User)e.ListItem).NameUser;
            string patronimyc = ((User)e.ListItem).PatronymicUser;
            e.Value = surname + " " + name + " " + patronimyc;
        }
    }
}
