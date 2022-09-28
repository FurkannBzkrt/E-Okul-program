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

namespace WindowsFormsApp1

    //
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            tBoxPicture.Text = openFileDialog1.FileName;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            SqlCommand commandRegister = new SqlCommand("Insert into AddPicture (StudentName,StudentSurname,StudentDepartment,StudentNo,StudentPicture)values (@pname,@psurname,@pdep,@pno,@ppic)",SqlOperations.connection);
            
            SqlOperations.CheckConnection(SqlOperations.connection);

            commandRegister.Parameters.AddWithValue("@pname",tBoxName.Text);
            commandRegister.Parameters.AddWithValue("@psurname", tBoxSurname.Text);
            commandRegister.Parameters.AddWithValue("@pdep", tBoxDepartment.Text);
            commandRegister.Parameters.AddWithValue("@pno", tBoxNo.Text);
            commandRegister.Parameters.AddWithValue("@ppic", tBoxPicture.Text);
           

            commandRegister.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi");

            LoadOrRefreshPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.addPictureTableAdapter.Fill(this.schoolDBDataSet.AddPicture);
            LoadOrRefreshPage();

        }

        public void LoadOrRefreshPage()
        {
            SqlCommand commandList = new SqlCommand("Select * from AddPicture",SqlOperations.connection);
            
            SqlOperations.CheckConnection(SqlOperations.connection);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);  // datatable ı dataadaptörle doldur.

            dataGridView1.DataSource = dt;
        }

        string selectedID;
        
       private void button1_Click(object sender, EventArgs e)
        {
            // DeleteButton
            
            SqlCommand commandDelete = new SqlCommand("Delete from AddPicture where StudentID=@pid ", SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            commandDelete.Parameters.AddWithValue("@pid", selectedID);

            commandDelete.ExecuteNonQuery();

            LoadOrRefreshPage();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedID = (dataGridView1.CurrentRow.Cells["StudentID"].Value).ToString();
            
            lblSelected.Text = selectedID.ToString();

            tBoxName.Text = (dataGridView1.CurrentRow.Cells["StudentName"].Value).ToString();
            tBoxSurname.Text = (dataGridView1.CurrentRow.Cells["StudentSurname"].Value).ToString();
            tBoxDepartment.Text = (dataGridView1.CurrentRow.Cells["StudentDepartment"].Value).ToString();
            tBoxNo.Text = (dataGridView1.CurrentRow.Cells["StudentNo"].Value).ToString();
            tBoxPicture.Text = (dataGridView1.CurrentRow.Cells["StudentPicture"].Value).ToString();
            

            pictureBox1.ImageLocation = (dataGridView1.CurrentRow.Cells["StudentPicture"].Value).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reset Textboxes
            tBoxName.Text = "";
            tBoxSurname.Text = "";
            tBoxDepartment.Text = "";
            tBoxNo.Text = "";
            tBoxPicture.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update AddPicture set StudentName = @pname, StudentSurname = @psurname , StudentDepartment = @pdep ,StudentNo = @pno , StudentPicture = @ppic where StudentID = @pid ", SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            commandEdit.Parameters.AddWithValue("@pname", tBoxName.Text);
            commandEdit.Parameters.AddWithValue("@psurname", tBoxSurname.Text);
            commandEdit.Parameters.AddWithValue("@pdep", tBoxDepartment.Text);
            commandEdit.Parameters.AddWithValue("@pno", tBoxNo.Text);
            commandEdit.Parameters.AddWithValue("@ppic", tBoxPicture.Text);
            commandEdit.Parameters.AddWithValue("@pid", selectedID);

            commandEdit.ExecuteNonQuery();

            LoadOrRefreshPage();


        }
    }
}
