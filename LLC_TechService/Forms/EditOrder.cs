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
        public EditOrder(Order order, Status status, Priority priority, Equipment equipment, User client, User master, Malfunction malfunction)
        {
            InitializeComponent();
            textBoxEquip.Text = equipment.NameEquipment;
            textBoxSerial.Text = $"{equipment.SerialEquipment}";
            //comboType.SelectedIndex = 0;
            textBoxProblem.Text = malfunction.NameMalfunction;
            //comboStatus.SelectedIndex = 0;
            //comboMaster.SelectedIndex = 0;
            //comboClient.SelectedIndex = 0;
            textBoxDesc.Text = order.DescOrder;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            using (var db = new LLCTechServiceContext())
            {
                var types = db.EquipmentTypes.OrderBy(x => x.IdEquipType);
                var masters = db.Users.Where(x => x.RoleUser == 2);
                var statuses = db.Statuses.OrderBy(x => x.IdStatus);
                var priorities = db.Priorities.OrderBy(x => x.IdPriority);

                comboType.DisplayMember = nameof(EquipmentType.NameEquipType);
                comboType.ValueMember = nameof(EquipmentType.IdEquipType);
                //comboMaster.DisplayMember = nameof(masters.);
                //comboType.ValueMember = nameof(EquipmentType.IdEquipType);


                comboType.Items.Clear();
                comboMaster.Items.AddRange(masters.ToArray());
                comboStatus.Items.AddRange(statuses.ToArray());
                comboPriority.Items.AddRange(priorities.ToArray());
                comboType.Items.AddRange(types.ToArray());

            }
        }
    }
}
