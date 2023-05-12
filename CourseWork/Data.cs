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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void parentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dayCareDataSet);

        }

        private void Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Relatives' table. You can move, or remove it, as needed.
            this.relativesTableAdapter.Fill(this.dayCareDataSet.Relatives);
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);
            // TODO: This line of code loads data into the 'dayCareDataSet.Parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.dayCareDataSet.Parents);

        }

      
    }
}
