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
    public partial class AddParts : Form
    {
        private bool oldPart;
        private bool newPart;
        public AddParts()
        {
            InitializeComponent();
            oldPart = true;
            newPart = false;

            textBoxPart.Visible = newPart;
            comboPart.Visible = oldPart;
            using (var db = new LLCTechServiceContext())
            {
                comboPart.DisplayMember = nameof(Part.TitlePart);
                comboPart.ValueMember = nameof(Part.IdPart);
                comboPart.Items.AddRange(db.Parts.OrderBy(x => x.IdPart).ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPart.Visible = !newPart;
            comboPart.Visible = !oldPart;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (var db = new LLCTechServiceContext())
            {
                if (oldPart == false)
                {
                    Part newPart = new Part
                    {
                        TitlePart = textBoxPart.Text,
                        AmountPart = Convert.ToInt32(numericUpDown.Value),
                    };

                    db.Parts.Add(newPart);
                    db.SaveChanges();
                }
                else if (oldPart == true)
                {
                    var newPart = db.Parts.FirstOrDefault(x => x.IdPart == ((Part)comboPart.SelectedItem).IdPart);
                    newPart.AmountPart = Convert.ToInt32(numericUpDown.Value);

                    db.Parts.Update(newPart);
                    db.SaveChanges();
                }

            }
        }

        private void comboPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown.Value = ((Part)comboPart.SelectedItem).AmountPart;
        }
    }
}
