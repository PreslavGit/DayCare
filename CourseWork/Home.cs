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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void списъкToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildrenUpdate childrenUpdate = new ChildrenUpdate();
            childrenUpdate.MdiParent = this;
            childrenUpdate.Show();
        }
        private void addParKids_Click(object sender, EventArgs e)
        {
            form_Add_Parent add = new form_Add_Parent();
            add.MdiParent = this;
            add.Show();
     
        }

        private void payMember_Click(object sender, EventArgs e)
        {
            frmPayPeriod payPeriod= new frmPayPeriod();
            payPeriod.MdiParent = this;
            payPeriod.Show();
        }

        private void payFoodTrans_Click(object sender, EventArgs e)
        {
            frmPayFood payFood = new frmPayFood();
            payFood.MdiParent = this;
            payFood.Show();
        }
        private void присъствиеПоДниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance attend = new Attendance();
            attend.MdiParent = this;
            attend.Show();
        }

        private void бройХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Meal meal = new Meal();
            meal.MdiParent = this;
            meal.Show();

        }

       

        private void заРодителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.MdiParent = this;
            data.Show();
        }

        private void присъствияПоДниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceDate attendanceData = new AttendanceDate();
            attendanceData.MdiParent = this;
            attendanceData.Show();
        }

        private void присъствиеПоДецаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceByChild attendanceData = new AttendanceByChild();
            attendanceData.MdiParent = this;
            attendanceData.Show();
        }

        private void наДетеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchChild searchChild = new SearchChild();    
            searchChild.MdiParent = this;
            searchChild.Show();
        }

        private void присъствияПоКласИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchGradeDate searchGradeDate = new SearchGradeDate();
            searchGradeDate.MdiParent = this;
            searchGradeDate.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Color floralWhite = Color.FloralWhite;

            int darkerR = (int)(floralWhite.R * 0.9);
            int darkerG = (int)(floralWhite.G * 0.9);
            int darkerB = (int)(floralWhite.B * 0.9);

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(darkerR, darkerG, darkerB);
        }
    }
}
