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
using AdminProject;


namespace AdminProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ///////////
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            SqlCommand commandRegister = new SqlCommand("Insert into AddPicture (StudentName,StudentSurname,StudentDepartment,StudentNo) values (@pname,@psurname,@pdepartment,@pno)", SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            commandRegister.Parameters.AddWithValue("@pname", tBoxName.Text);
            commandRegister.Parameters.AddWithValue("@psurname", tBoxSurname.Text);
            commandRegister.Parameters.AddWithValue("@pdepartment", tBoxDepartment.Text);
            commandRegister.Parameters.AddWithValue("@pno", tBoxNo.Text);

            commandRegister.ExecuteNonQuery();

            MessageBox.Show("Kayıt olundu.");
        } 

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Çıkmak istiyor musunuz? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLoginYes_Click(object sender, EventArgs e)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from AddPicture where StudentName=@pname and StudentNo=@pno",SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            commandLogin.Parameters.AddWithValue("@pname", tboxLoginName.Text);
            commandLogin.Parameters.AddWithValue("@pno", tboxLoginNo.Text);

            SqlDataAdapter da = new SqlDataAdapter(commandLogin);

            DataTable dt = new DataTable();
            
            da.Fill(dt);
            
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Giriş Yapıldı.");
                Variables.loggedStudentName = dt.Rows[0]["StudentName"].ToString();
                Variables.loggedStudentSurname = dt.Rows[0]["StudentSurname"].ToString();
                Variables.loggedStudentNo = Convert.ToInt32(dt.Rows[0]["StudentNo"]);
                Variables.loggedStudentDepartment = dt.Rows[0]["StudentDepartment"].ToString();
                Variables.loggedStudentPicture = dt.Rows[0]["StudentPicture"].ToString();
                //Variables.loggedGrade = Convert.ToInt32(dt.Rows[0]["Grade"]);
                
                Form2 newform = new Form2();
                newform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı ! ");
            }

        }
    }

}
