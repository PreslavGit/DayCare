using CourseWork.DayCareDataSetTableAdapters;
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
    public partial class form_Add_Parent : Form
    {
        public form_Add_Parent()
        {
            InitializeComponent();
        }

        private void btn_Add_Parent_Click(object sender, EventArgs e)
        {
            DayCareDataSet.ParentsRow newParentsRow = dayCareDataSet.Parents.NewParentsRow();

            newParentsRow.FirstName = tb_Parent_Name.Text;
            newParentsRow.LastName = tb_Parent_LastName.Text;
            newParentsRow.Email = tb_Parent_Email.Text;
            newParentsRow.Phone = tb_Parent_Phone.Text;

            dayCareDataSet.Parents.Rows.Add(newParentsRow);
            parentsTableAdapter.Update(dayCareDataSet.Parents);

            //RELATIVE
            DayCareDataSet.RelativesRow newRelativeRow = dayCareDataSet.Relatives.NewRelativesRow();

            newRelativeRow.ParentID = newParentsRow.id;
            newRelativeRow.Relation = tb_Parent_Relative_Relation.Text;
            newRelativeRow.Phone = tb_Parent_Relative_Phone.Text;

            dayCareDataSet.Relatives.Rows.Add(newRelativeRow);
            relativesTableAdapter.Update(dayCareDataSet.Relatives);

            


            MessageBox.Show(tb_Parent_Name.Text + " " + tb_Parent_LastName.Text + " беше успешно добавен/a");
            clearParentsTextBoxes();
        }

        private void clearParentsTextBoxes()
        {
            tb_Parent_Name.Text = "";
            tb_Parent_LastName.Text = "";
            tb_Parent_Email.Text = "";
            tb_Parent_Phone.Text = ""; 
            tb_Parent_Relative_Relation.Text = "";
            tb_Parent_Relative_Phone.Text = "";

        }

        private void form_Add_Parent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dayCareDataSet.Relatives' table. You can move, or remove it, as needed.
            this.relativesTableAdapter.Fill(this.dayCareDataSet.Relatives);
            // TODO: This line of code loads data into the 'dayCareDataSet.Parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.dayCareDataSet.Parents);

        }

        private void btn_Add_Child_Click(object sender, EventArgs e)
        {
            try
            {
                DayCareDataSet.ChildrenRow newChildRow = dayCareDataSet.Children.NewChildrenRow();

                newChildRow.ParentID = Convert.ToInt32(cbb_Child_Parent.SelectedValue);
                newChildRow.FirstName = tb_Child_Name.Text;
                newChildRow.LastName = tb_Child_LastName.Text;
                newChildRow.Age = Convert.ToInt32(tb_Child_Age.Text);
                newChildRow.Grade = Convert.ToInt32(tb_Child_Grade.Text);
                newChildRow.Info = tb_Child_Info.Text;
                newChildRow.Meals = 0;

                dayCareDataSet.Children.Rows.Add(newChildRow);
                childrenTableAdapter.Update(dayCareDataSet.Children);


                MessageBox.Show(tb_Child_Name.Text + " " + tb_Child_LastName.Text + " беше успешно добавен/a");
                clearChildrenTextBoxes();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void clearChildrenTextBoxes()
        {
            tb_Child_Name.Text = "";
            tb_Child_LastName.Text = "";
            tb_Child_Age.Text = "";
            tb_Parent_Phone.Text = "";
            tb_Child_Grade.Text = "";
            tb_Child_Info.Text = "";

        }

    }
}
