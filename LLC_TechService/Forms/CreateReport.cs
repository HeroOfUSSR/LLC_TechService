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
    public partial class CreateReport : Form
    {
        private Order reportOrder;
        private Dictionary<Part, int> partMap;
        public CreateReport(Order order)
        {
            InitializeComponent();
            Text = $"Отчёт к заказу №{order.IdOrder}";

            partMap = new Dictionary<Part, int>();

            reportOrder = order;
        }

        private void CreateReport_Load(object sender, EventArgs e)
        {
            using (var db = new LLCTechServiceContext())
            {
                var parts = db.Parts.OrderByDescending(x => x.IdPart);

                foreach (var part in parts)
                {
                    var partView = new PartView(part);
                    partView.Parent = flowLayoutPanel1;

                    partView.PartAdded += PartView_PartAdded;
                }
            }
        }

        private void PartView_PartAdded(object sender, (Part, int) e)
        {
            if (partMap.TryGetValue(e.Item1, out var count))
            {
                partMap[e.Item1] = ++count;
            }
            else partMap.Add(e.Item1, e.Item2);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxProblem.Text != "" || textBoxMoney.Text != "")
            {
                using (var db = new LLCTechServiceContext())
                {
                    Malfunction newProblem = new Malfunction
                    {
                        NameMalfunction = textBoxProblem.Text
                    };

                    db.Malfunctions.Add(newProblem);
                    db.SaveChanges();

                    Report newReport = new Report
                    {
                        OrderReport = reportOrder.IdOrder,
                        DateReport = DateTime.Now,
                        CostReport = Convert.ToDecimal(textBoxMoney.Text),
                        MalfunctionReport = db.Malfunctions
                            .OrderBy(x => x.IdMalfunction)
                            .Last().IdMalfunction,
                        DescReport = textBoxDesc.Text,
                        MasterReport = Login.currentUser.IdUser,
                    };

                    db.Reports.Add(newReport);
                    db.SaveChanges();

                    foreach (var item in partMap.Keys)
                    {
                        UsedPart newUserParts = new UsedPart
                        {
                            AmountUsedParts = partMap[item],
                            PartsId = item.IdPart,
                            ReportUsedParts = db.Reports.OrderBy(x => x.IdReport).Last().IdReport,
                        };

                        var removeParts = db.Parts.FirstOrDefault(x => x.IdPart == item.IdPart);
                        removeParts.AmountPart -= partMap[item];

                        db.Parts.Update(removeParts);
                        db.UsedParts.Add(newUserParts);
                        db.SaveChanges();
                    }

                    var finishOrder = db.Orders.FirstOrDefault(x => x.IdOrder == reportOrder.IdOrder);
                    finishOrder.StatusOrder = 1;

                    db.Orders.Update(finishOrder);
                    db.SaveChanges();

                    MessageBox.Show("Заказ завершён");
                    this.Close();
                }
            }
            else MessageBox.Show("Введите данные во все поля со звёздочкой");
            
        }
    }
}
