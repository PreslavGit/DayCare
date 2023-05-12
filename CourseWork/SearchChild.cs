using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SearchChild : Form
    {
        public SearchChild()
        {
            InitializeComponent();
        }

        private void SearchChild_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);
            cbChildName.SelectedIndex = -1;
        }

        private void cbChildName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString;

            string query = "SELECT Children.FirstName + ' ' + Children.LastName as Име, " +
                           "CONVERT(VARCHAR(10), Payments.StartDate) + ' - ' + CONVERT(VARCHAR(10), Payments.EndDate) as Период, " +
                           "COUNT (*) as Посещения " +
                           "FROM Children INNER JOIN Payments ON Children.id = Payments.ChildID " +
                           "INNER JOIN Attendance ON Attendance.ChildID = Children.id " +
                           "WHERE Children.id = @childID AND(SELECT MAX(id) as maxID FROM Payments WHERE Payments.ChildID = Children.id AND Attendance.Date >= Payments.StartDate AND Attendance.Date <= Payments.EndDate) = Payments.id " +
                           "GROUP BY Children.FirstName + ' ' + Children.LastName, " +
                           "CONVERT(VARCHAR(10), Payments.StartDate) + ' - ' + CONVERT(VARCHAR(10), Payments.EndDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@childID", cbChildName.SelectedValue ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            dgChildInfo.DataSource = dt;
            dgChildInfo.Columns["Период"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
