using CourseWork.DayCareDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class frmPayPeriod : Form
    {
        public frmPayPeriod()
        {
            InitializeComponent();
        }

        private void frmPayPeriod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DayCareDataSet.PaymentsRow newPaymentsRow = dayCareDataSet.Payments.NewPaymentsRow();

            newPaymentsRow.ChildID = Convert.ToInt32(cbbPay.SelectedValue);
            newPaymentsRow.StartDate = dt_StartDate.Value;
            newPaymentsRow.EndDate = dt_StartDate.Value.AddDays(Convert.ToInt32(tb_Days.Text));

            dayCareDataSet.Payments.Rows.Add(newPaymentsRow);
            paymentsTableAdapter.Update(dayCareDataSet.Payments);

            MessageBox.Show("За " + (cbbPay.GetItemText(cbbPay.SelectedItem)) + " е заплатена такса \nОт: " + dt_StartDate.Value.ToShortDateString() + " \nДо: " + dt_StartDate.Value.AddDays(Convert.ToInt32(tb_Days.Text)).ToShortDateString());
        }

        private void tb_Days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
