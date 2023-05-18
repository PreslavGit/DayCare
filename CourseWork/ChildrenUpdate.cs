using OfficeOpenXml;
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
    public partial class ChildrenUpdate : Form
    {
        public ChildrenUpdate()
        {
            InitializeComponent();
        }

        private void childrenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.childrenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dayCareDataSet);

        }

        private void ChildrenUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Children' table. You can move, or remove it, as needed.
            this.childrenTableAdapter.Fill(this.dayCareDataSet.Children);

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string tableName = "Children";
            var dataTable = dayCareDataSet.Tables[tableName];
            dataTable.Columns.Remove("FullName");

            string connectionString = ConfigurationManager.ConnectionStrings["CourseWork.Properties.Settings.DayCareConnectionString"].ConnectionString;
            string query = "SELECT * FROM " + tableName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            ExportToExcel(dataTable);
        }
        private void ExportToExcel(DataTable dataTable)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                    excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                }
            }
        }
    }
}
