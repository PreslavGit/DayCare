using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgMeal.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells["Ate"].Value) == true)
                {
                    row.Cells[1].Value = Convert.ToInt32(row.Cells[1].Value) - 1;
                }
            }
            try
            {
                childrenTableAdapter.Update(dayCareDataSet.Children);
                MessageBox.Show("Записването бе успешно");
                this.Hide();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
