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
    public partial class frmPayFood : Form
    {
        public frmPayFood()
        {
            InitializeComponent();
        }

        private void frmPayFood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);

        }

        private void txtPayKidsF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPayKidsT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnPayFood_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cbbPayKidsF.SelectedValue);

            DataRow row = dayCareDataSet.Children.FindByid(id);

            row["Meals"] = Convert.ToInt32(tbPayKidsF.Text) + Convert.ToInt32(row["Meals"]);

            childrenTableAdapter.Update(dayCareDataSet.Children);

            MessageBox.Show("Добавени са " + tbPayKidsF.Text + " хранения на " + row["FullName"] + ". \nИма общо " + row["Meals"]);
        }
    }
}
