namespace wearther_desktop
{
    partial class Registracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracija));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_Email2 = new System.Windows.Forms.TextBox();
            this.tb_Password2 = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_RegisterPage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(772, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.Black;
            this.btn_min.Location = new System.Drawing.Point(744, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 21;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::wearther_desktop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(291, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Name.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tb_Name.Location = new System.Drawing.Point(301, 181);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(237, 28);
            this.tb_Name.TabIndex = 23;
            // 
            // tb_LastName
            // 
            this.tb_LastName.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_LastName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tb_LastName.Location = new System.Drawing.Point(301, 229);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(237, 28);
            this.tb_LastName.TabIndex = 24;
            // 
            // tb_Email2
            // 
            this.tb_Email2.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Email2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tb_Email2.Location = new System.Drawing.Point(301, 280);
            this.tb_Email2.Name = "tb_Email2";
            this.tb_Email2.Size = new System.Drawing.Size(237, 28);
            this.tb_Email2.TabIndex = 25;
            this.tb_Email2.TextChanged += new System.EventHandler(this.Tb_Email2_TextChanged);
            this.tb_Email2.Leave += new System.EventHandler(this.Tb_Email_Leave);
            // 
            // tb_Password2
            // 
            this.tb_Password2.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Password2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tb_Password2.Location = new System.Drawing.Point(301, 330);
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.PasswordChar = '*';
            this.tb_Password2.Size = new System.Drawing.Size(237, 28);
            this.tb_Password2.TabIndex = 26;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(65)))));
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(436, 374);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(102, 28);
            this.btn_Register.TabIndex = 27;
            this.btn_Register.Text = "Registriraj se";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(242, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(239, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(242, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(242, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lozinka";
            // 
            // lbl_RegisterPage
            // 
            this.lbl_RegisterPage.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_RegisterPage.AutoSize = true;
            this.lbl_RegisterPage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RegisterPage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.lbl_RegisterPage.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_RegisterPage.LinkColor = System.Drawing.Color.White;
            this.lbl_RegisterPage.Location = new System.Drawing.Point(303, 377);
            this.lbl_RegisterPage.Name = "lbl_RegisterPage";
            this.lbl_RegisterPage.Size = new System.Drawing.Size(95, 20);
            this.lbl_RegisterPage.TabIndex = 32;
            this.lbl_RegisterPage.TabStop = true;
            this.lbl_RegisterPage.Text = "Imaš račun?";
            this.lbl_RegisterPage.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbl_RegisterPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_RegisterPage_LinkClicked);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wearther_desktop.Properties.Resources.registracijastr;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_RegisterPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Password2);
            this.Controls.Add(this.tb_Email2);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_Email2;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbl_RegisterPage;
    }
}