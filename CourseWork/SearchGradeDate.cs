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
using static System.Windows.Forms.AxHost;

namespace CourseWork
{
    public partial class SearchGradeDate : Form
    {
        public SearchGradeDate()
        {
            InitializeComponent();
        }

        private void SearchGradeDate_Load(object sender, EventArgs e)
        { 
            string queryDate =  "SELECT DISTINCT Attendance.Date " +
                                "FROM Attendance " +
                                "ORDER BY Attendance.Date DESC";
            string queryGrade = "SELECT DISTINCT Children.Grade " +
                                "FROM Children ";

            loadComboBox(queryGrade, "Grade", cbGrade);
            loadComboBox(queryDate, "Date", cbDate);
        }

        private void loadComboBox(String query, String colName, ComboBox cb)
        {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapterGrade = new SqlDataAdapter(query, connection);
                adapterGrade.Fill(dt);
            }

            cb.DataSource = dt;
            cb.DisplayMember = colName;
            cb.ValueMember = colName;
            cb.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString;

            string query =  "SELECT Children.FirstName + ' ' + Children.LastName as Име " +
                            "FROM Children INNER JOIN Attendance ON Attendance.ChildID = Children.id " +
                            "WHERE Attendance.Date = @date AND Children.Grade = @grade";

            if (cbDate.SelectedValue != null && cbGrade.SelectedValue != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@date", cbDate.SelectedValue);
                    cmd.Parameters.AddWithValue("@grade", cbGrade.SelectedValue);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            else
            {
                MessageBox.Show("Не са избрани стойности");
            }

            dgDateGrade.DataSource = dt;
        }
    }
}
