using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AttendanceDate : Form
    {
        public AttendanceDate()
        {
            InitializeComponent();
        }

        private void showData(DateRangeEventArgs e)
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString;
            string query = "SELECT Children.FirstName + ' ' + Children.LastName as Име FROM Attendance " +
                            "INNER JOIN Children ON Attendance.ChildID = Children.id " +
                            "WHERE Attendance.Date = '" + e.Start.ToString("yyyy-MM-dd") + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            dgAttendData.DataSource = dt;
            dgAttendData.Columns["Име"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void calAttendData_DateSelected(object sender, DateRangeEventArgs e)
        {
            showData(e);
        }
    }
}
