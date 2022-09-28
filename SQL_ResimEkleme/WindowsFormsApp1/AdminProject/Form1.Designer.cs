
namespace AdminProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.btnLoginYes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxLoginName = new System.Windows.Forms.TextBox();
            this.tboxLoginNo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tBoxDepartment);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tBoxNo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tBoxSurname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tBoxName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::AdminProject.Properties.Resources.NO;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(456, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 46);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = global::AdminProject.Properties.Resources._evet_5;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Location = new System.Drawing.Point(610, 358);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 46);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminProject.Properties.Resources.peakpx;
            this.pictureBox1.Location = new System.Drawing.Point(81, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxDepartment
            // 
            this.tBoxDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tBoxDepartment.Font = new System.Drawing.Font("Jokerman", 12F);
            this.tBoxDepartment.Location = new System.Drawing.Point(610, 231);
            this.tBoxDepartment.Name = "tBoxDepartment";
            this.tBoxDepartment.Size = new System.Drawing.Size(100, 38);
            this.tBoxDepartment.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label4.Location = new System.Drawing.Point(434, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Department:";
            // 
            // tBoxNo
            // 
            this.tBoxNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tBoxNo.Font = new System.Drawing.Font("Jokerman", 12F);
            this.tBoxNo.Location = new System.Drawing.Point(610, 295);
            this.tBoxNo.Name = "tBoxNo";
            this.tBoxNo.PasswordChar = '*';
            this.tBoxNo.Size = new System.Drawing.Size(100, 38);
            this.tBoxNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label5.Location = new System.Drawing.Point(434, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password:";
            // 
            // tBoxSurname
            // 
            this.tBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tBoxSurname.Font = new System.Drawing.Font("Jokerman", 12F);
            this.tBoxSurname.Location = new System.Drawing.Point(610, 171);
            this.tBoxSurname.Name = "tBoxSurname";
            this.tBoxSurname.Size = new System.Drawing.Size(100, 38);
            this.tBoxSurname.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label3.Location = new System.Drawing.Point(434, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 25F);
            this.label2.Location = new System.Drawing.Point(460, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 61);
            this.label2.TabIndex = 14;
            this.label2.Text = "REGISTER";
            // 
            // tBoxName
            // 
            this.tBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tBoxName.Font = new System.Drawing.Font("Jokerman", 12F);
            this.tBoxName.Location = new System.Drawing.Point(610, 107);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 38);
            this.tBoxName.TabIndex = 13;
            this.tBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label1.Location = new System.Drawing.Point(434, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnLoginCancel);
            this.tabPage2.Controls.Add(this.btnLoginYes);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tboxLoginName);
            this.tabPage2.Controls.Add(this.tboxLoginNo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdminProject.Properties.Resources.Joker_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(7, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.BackgroundImage = global::AdminProject.Properties.Resources.NO;
            this.btnLoginCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginCancel.Location = new System.Drawing.Point(461, 323);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(87, 46);
            this.btnLoginCancel.TabIndex = 36;
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoginYes
            // 
            this.btnLoginYes.BackgroundImage = global::AdminProject.Properties.Resources._evet_5;
            this.btnLoginYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginYes.Location = new System.Drawing.Point(576, 323);
            this.btnLoginYes.Name = "btnLoginYes";
            this.btnLoginYes.Size = new System.Drawing.Size(79, 46);
            this.btnLoginYes.TabIndex = 35;
            this.btnLoginYes.UseVisualStyleBackColor = true;
            this.btnLoginYes.Click += new System.EventHandler(this.btnLoginYes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Jokerman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 87);
            this.label8.TabIndex = 33;
            this.label8.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 31;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 37);
            this.label7.TabIndex = 30;
            this.label7.Text = "UserName:";
            // 
            // tboxLoginName
            // 
            this.tboxLoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tboxLoginName.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLoginName.Location = new System.Drawing.Point(461, 191);
            this.tboxLoginName.Name = "tboxLoginName";
            this.tboxLoginName.Size = new System.Drawing.Size(182, 45);
            this.tboxLoginName.TabIndex = 29;
            // 
            // tboxLoginNo
            // 
            this.tboxLoginNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tboxLoginNo.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLoginNo.Location = new System.Drawing.Point(461, 243);
            this.tboxLoginNo.Name = "tboxLoginNo";
            this.tboxLoginNo.PasswordChar = '*';
            this.tboxLoginNo.Size = new System.Drawing.Size(182, 45);
            this.tboxLoginNo.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Button btnLoginYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxLoginName;
        private System.Windows.Forms.TextBox tboxLoginNo;
    }
}

