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
    public partial class PartView : UserControl
    {
        private EventHandler<(Part, int)> onPartAdded;

        public Part part;
        public int Count;
        public PartView(Part part)
        {
            InitializeComponent();
            Init_View(part);
            this.part = part;
        }

        private void Init_View(Part part)
        {
            labelName.Text = part.TitlePart;
            labelAmount.Text = $"{part.AmountPart}";
        }

        public event EventHandler<(Part, int)> PartAdded
        {
            add
            {
                onPartAdded += value;
            }
            remove
            {
                onPartAdded -= value;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Count = (int)numericUpDown.Value;

            onPartAdded?.Invoke(this, (part, Count));
        }
        
    }
}
