using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdminProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        public void LoadOrRefresh()
        {
            SqlCommand commandList = new SqlCommand("Select * from AddPicture", SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);  // datatable ı dataadaptörle doldur.

            dataGridView1.DataSource = dt;
        }

        string selectedID;

        
        


        private void Form2_Load(object sender, EventArgs e)
        {

            tboxForm2Name.Text = $" {Variables.loggedStudentName }";
            tboxForm2Surname.Text = $" {Variables.loggedStudentSurname }";
            tboxForm2Dep.Text = $" {Variables.loggedStudentDepartment }";
            tBoxForm2No.Text = $" {Variables.loggedStudentNo }";
            pictureBoxFomr2.ImageLocation = $" {Variables.loggedStudentPicture}";
            // tBoxGrade.Text = $"{Variables.loggedGrade}";

            //işe yaramadı.....
            /*
            tboxForm2Surname.Text = (labelSurname.Text).ToString();
            tboxForm2Name.Text = labelName.Text;
            tboxForm2Dep.Text = labelDep.Text;
            tBoxForm2No.Text = labelNO.Text;
            //tBoxGrade.Text = labelGrade.Text;
            */
            LoadOrRefresh();

        }

        private void btnForm2Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor...");
            Variables.loggedStudentName = null;
            Variables.loggedStudentSurname = null;
            Variables.loggedStudentDepartment = null;
            Variables.loggedStudentNo = 0;
            Variables.loggedStudentPicture = null;
            Variables.loggedGrade = 0;

            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }

        

        private void btnForm2Edit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update AddPicture set StudentName = @pname, StudentSurname = @psurname , StudentDepartment = @pdep ,StudentNo = @pno , StudentPicture = @ppic where StudentID = @pid ", SqlOperations.connection);

            //, Grade = @pgrade

            SqlOperations.CheckConnection(SqlOperations.connection);

           
            
            commandEdit.Parameters.AddWithValue("@pname", tboxForm2Name.Text);
            commandEdit.Parameters.AddWithValue("@psurname", tboxForm2Surname.Text);
            commandEdit.Parameters.AddWithValue("@pdep", tboxForm2Dep.Text);
            commandEdit.Parameters.AddWithValue("@pno", tBoxForm2No.Text);
            commandEdit.Parameters.AddWithValue("@ppic", tBoxForm2Pic.Text);
            commandEdit.Parameters.AddWithValue("@pid", selectedID);
           // commandEdit.Parameters.AddWithValue("@pgrade", tBoxGrade.Text);

            commandEdit.ExecuteNonQuery();

            LoadOrRefresh();

        }

        
        private void btnform2Pic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxFomr2.ImageLocation = openFileDialog1.FileName;
            tBoxForm2Pic.Text = openFileDialog1.FileName;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedID = (dataGridView1.CurrentRow.Cells["StudentID"].Value).ToString();


            tboxForm2Name.Text = (dataGridView1.CurrentRow.Cells["StudentName"].Value).ToString();
            tboxForm2Surname.Text = (dataGridView1.CurrentRow.Cells["StudentSurname"].Value).ToString();
            tboxForm2Dep.Text = (dataGridView1.CurrentRow.Cells["StudentDepartment"].Value).ToString();
            tBoxForm2No.Text = (dataGridView1.CurrentRow.Cells["StudentNo"].Value).ToString();
            tBoxForm2Pic.Text = (dataGridView1.CurrentRow.Cells["StudentPicture"].Value).ToString();
           // tBoxGrade.Text =(dataGridView1.CurrentRow.Cells["Grade"].Value).ToString();

            pictureBoxFomr2.ImageLocation = (dataGridView1.CurrentRow.Cells["StudentPicture"].Value).ToString();
        }

        int hak = 3;

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            
            
            while (true)
            {
                  
                    if (tBoxAdmin.Text == "12345")
                    {
                        dataGridView1.Visible = true;
                        btnForm2Edit.Visible = true; 
                        tBoxAdmin.Text = "";
                        tBoxAdmin.Visible = false;
                        btnAdmin.Visible = false;
                        btnAdminCancel.Visible = false;
                        lblAdminPassword.Visible = false;
                        break;
                    }
                    else
                    {
                       
                        MessageBox.Show("Girdiğiniz Şifre yanlış..");
                        tBoxAdmin.Text = "";

                        if (hak <= 3)
                        {
                            hak--;
                        }
                        if (hak == 0)
                        {
                             MessageBox.Show("Daha fazla deneyemezsiniz..");
                             tBoxAdmin.Visible = false;
                             btnAdmin.Visible = false;
                             btnAdminCancel.Visible = false;
                             lblAdminPassword.Visible = false;
                             break;
                        }
                        break;
                    
                    }
                  
                
            }

        }

        private void btnAdminCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            tBoxAdmin.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
