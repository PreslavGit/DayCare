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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CourseWork
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            DataTable activeMembersTable = new DataTable();

            string query = 
               "SELECT Children.id, " +
               "Children.FirstName + ' ' + Children.LastName as Име, " +
               "Payments.StartDate as От, " +
               "Payments.EndDate as До, " +
               "CASE WHEN Attendance.Date = CONVERT(DATE, GETDATE()) THEN 1 ELSE 0 END as IsPresent " +
               "FROM Children " +
               "INNER JOIN Payments ON Children.id = Payments.ChildID " +
               "LEFT JOIN " +
               "(SELECT * FROM Attendance WHERE Date = CONVERT(DATE, GETDATE())) Attendance ON Children.id = Attendance.ChildID " +
               "WHERE Payments.StartDate <= GETDATE() AND Payments.EndDate >= GETDATE()";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(activeMembersTable);
            }

            dgAttendance.DataSource = activeMembersTable;
            dgAttendance.Columns["id"].Visible = false;
            dgAttendance.Columns["IsPresent"].Visible = false;

            DataGridViewCheckBoxColumn attendCol = new DataGridViewCheckBoxColumn();
            attendCol.Name = "attendCol";
            attendCol.HeaderText = "Присъствие";;
            attendCol.DataPropertyName = "IsPresent";

            dgAttendance.Columns.Add(attendCol);
        }

        private void btnSubmitAttend_Click(object sender, EventArgs e)
        { 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString);
            connection.Open();

            insertAttendance(connection);

            connection.Close(); 
        }

        private void insertAttendance(SqlConnection connection)
        {
            foreach (DataGridViewRow row in dgAttendance.Rows)
            {
                try
                {
                    if (row.Cells["isPresent"].Value != DBNull.Value &&Convert.ToInt32(row.Cells["isPresent"].Value) == 1)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Attendance (ChildID, date) VALUES (@id, @date)", connection);
                        cmd.Parameters.AddWithValue("@id", row.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) //code for dupe entry
                        continue;
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }
            MessageBox.Show("Всички отбелязани деца бяха успешно добавени");
        }

    }
}
