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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxEquip.Text == null || textBoxProblem.Text == null || textBoxSerial.Text == null)
            {
                MessageBox.Show("Все поля со звёздочкой обязательны к заполнению!");
                return;
            }

            using (var db = new LLCTechServiceContext())
            {
                Malfunction newProblem = new Malfunction
                {
                    NameMalfunction = textBoxProblem.Text
                };

                Equipment newEquip = new Equipment
                {
                    NameEquipment = textBoxEquip.Text,
                    SerialEquipment = Convert.ToInt32(textBoxSerial.Text),
                    TypeEquipment = ((EquipmentType)comboType.SelectedItem).IdEquipType,
                };

                db.Malfunctions.Add(newProblem);
                db.Equipment.Add(newEquip);

                db.SaveChanges();

                Order newOrder = new Order
                {
                    EquipmentOrder = db.Equipment.OrderBy(x => x.IdEquipment).Last().IdEquipment,
                    DescOrder = textBoxDesc.Text,
                    MalfunctionOrder = db.Malfunctions.OrderBy(x => x.IdMalfunction).Last().IdMalfunction,
                    ClientOrder = Login.currentUser.IdUser,
                    StatusOrder = 3,
                    PriorityOrder = 2,
                    DateOrder = DateTime.Now,
                    //MasterOrder = db.Users.FirstOrDefault(x => x.RoleUser == 2).IdUser,
                };

                db.Orders.Add(newOrder);

                db.SaveChanges();

                MessageBox.Show($"Заказ №{db.Orders.OrderBy(x => x.IdOrder).Last().IdOrder} оформлен");
                this.Close();
            }
        }

      

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            using (var db = new LLCTechServiceContext())
            {
                var types = db.EquipmentTypes.OrderBy(x => x.IdEquipType);

                comboType.DisplayMember = nameof(EquipmentType.NameEquipType);
                comboType.ValueMember = nameof(EquipmentType.IdEquipType);

                comboType.Items.Clear();
                comboType.Items.AddRange(types.ToArray());

                comboType.SelectedIndex = 0;
            }
        }

    }
}
