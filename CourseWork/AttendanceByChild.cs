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
    public partial class AttendanceByChild : Form
    {
        public AttendanceByChild()
        {
            InitializeComponent();
        }

        private void childrenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.childrenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dayCareDataSet);

        }

        private void AttendanceByChild_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.dayCareDataSet.Attendance);
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);

        }
    }
}
