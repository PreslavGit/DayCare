using OfficeOpenXml;
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            DataTable parentsTable = dayCareDataSet.Tables["Parents"].Copy();
            DataTable childrenTable = dayCareDataSet.Tables["Children"].Copy();
            DataTable relativesTable = dayCareDataSet.Tables["Relatives"].Copy();
            DataTable combined = new DataTable();

            parentsTable.Columns.Remove("FullName");
            childrenTable.Columns.Remove("FullName");

            renameColumns(parentsTable, relativesTable, childrenTable);

            combined.Merge(parentsTable, false, MissingSchemaAction.Add);
            combined.Merge(relativesTable, false, MissingSchemaAction.Add);
            combined.Merge(childrenTable, false, MissingSchemaAction.Add);

            combined.DefaultView.Sort = combined.Columns[5].ColumnName + " ASC";
            combined = combined.DefaultView.ToTable();

            ExportToExcel(combined);
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
                    worksheet.Columns.AutoFit();
                    excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                }
            }
        }

        private void renameColumns(DataTable parentsTable, DataTable relativesTable, DataTable childrenTable)
        {
            parentsTable.Columns["FirstName"].ColumnName = "Име на родител";
            parentsTable.Columns["LastName"].ColumnName = "Фамилия на родител";
            parentsTable.Columns["Phone"].ColumnName = "Телефон на родител";

            relativesTable.Columns["Relation"].ColumnName = "Познат";

            childrenTable.Columns["FirstName"].ColumnName = "Име на дете";
            childrenTable.Columns["LastName"].ColumnName = "Фамилия на дете";
            childrenTable.Columns["Age"].ColumnName = "Години";
            childrenTable.Columns["Grade"].ColumnName = "Клас";
            childrenTable.Columns["Info"].ColumnName = "Информация";
            childrenTable.Columns["Meals"].ColumnName = "Хранения";
        }
    }
}
