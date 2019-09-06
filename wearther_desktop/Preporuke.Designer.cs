namespace wearther_desktop
{
    partial class Preporuke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preporuke));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.cb_Temp = new System.Windows.Forms.ComboBox();
            this.btn_Ormar = new System.Windows.Forms.Button();
            this.rb_Kisa = new System.Windows.Forms.RadioButton();
            this.rb_Sunce = new System.Windows.Forms.RadioButton();
            this.btn_Preporuka = new System.Windows.Forms.Button();
            this.img_Hlace = new System.Windows.Forms.PictureBox();
            this.img_Jakna = new System.Windows.Forms.PictureBox();
            this.img_Obuca = new System.Windows.Forms.PictureBox();
            this.img_Majica = new System.Windows.Forms.PictureBox();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.btn_Preporuke = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Preporuke = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Snijeg = new System.Windows.Forms.RadioButton();
            this.lbl_Korisnik = new System.Windows.Forms.Label();
            this.btn_Odjava = new System.Windows.Forms.Button();
            this.btn_Ideja = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img_Haljina = new System.Windows.Forms.PictureBox();
            this.cb_Haljina = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Jakna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Obuca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Majica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Haljina)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(965, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.Black;
            this.btn_min.Location = new System.Drawing.Point(937, 5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 22;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Temp.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp.Location = new System.Drawing.Point(242, 109);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(139, 25);
            this.lbl_Temp.TabIndex = 32;
            this.lbl_Temp.Text = "Unesite temperaturu";
            // 
            // cb_Temp
            // 
            this.cb_Temp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Temp.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Temp.FormattingEnabled = true;
            this.cb_Temp.Items.AddRange(new object[] {
            "<5°C",
            "5-10°C",
            "10-20°C",
            "20-25°C",
            ">25°C"});
            this.cb_Temp.Location = new System.Drawing.Point(387, 107);
            this.cb_Temp.Name = "cb_Temp";
            this.cb_Temp.Size = new System.Drawing.Size(99, 30);
            this.cb_Temp.TabIndex = 35;
            this.cb_Temp.SelectedIndexChanged += new System.EventHandler(this.Cb_Temp_SelectedIndexChanged);
            // 
            // btn_Ormar
            // 
            this.btn_Ormar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Ormar.FlatAppearance.BorderSize = 0;
            this.btn_Ormar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ormar.Font = new System.Drawing.Font("Dubai", 11.25F);
            this.btn_Ormar.ForeColor = System.Drawing.Color.White;
            this.btn_Ormar.Image = global::wearther_desktop.Properties.Resources.wardrobe;
            this.btn_Ormar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ormar.Location = new System.Drawing.Point(0, 219);
            this.btn_Ormar.Name = "btn_Ormar";
            this.btn_Ormar.Size = new System.Drawing.Size(199, 40);
            this.btn_Ormar.TabIndex = 24;
            this.btn_Ormar.Text = "Ormar";
            this.btn_Ormar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ormar.UseVisualStyleBackColor = false;
            this.btn_Ormar.Click += new System.EventHandler(this.Btn_Ormar_Click);
            // 
            // rb_Kisa
            // 
            this.rb_Kisa.BackColor = System.Drawing.Color.Transparent;
            this.rb_Kisa.Image = global::wearther_desktop.Properties.Resources.rain;
            this.rb_Kisa.Location = new System.Drawing.Point(352, 20);
            this.rb_Kisa.Name = "rb_Kisa";
            this.rb_Kisa.Size = new System.Drawing.Size(70, 45);
            this.rb_Kisa.TabIndex = 34;
            this.rb_Kisa.TabStop = true;
            this.rb_Kisa.UseVisualStyleBackColor = false;
            this.rb_Kisa.CheckedChanged += new System.EventHandler(this.Rb_Kisa_CheckedChanged);
            // 
            // rb_Sunce
            // 
            this.rb_Sunce.BackColor = System.Drawing.Color.Transparent;
            this.rb_Sunce.Image = global::wearther_desktop.Properties.Resources.sunny__3_;
            this.rb_Sunce.Location = new System.Drawing.Point(278, 20);
            this.rb_Sunce.Name = "rb_Sunce";
            this.rb_Sunce.Size = new System.Drawing.Size(70, 45);
            this.rb_Sunce.TabIndex = 33;
            this.rb_Sunce.TabStop = true;
            this.rb_Sunce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Sunce.UseVisualStyleBackColor = false;
            this.rb_Sunce.CheckedChanged += new System.EventHandler(this.Rb_Sunce_CheckedChanged);
            // 
            // btn_Preporuka
            // 
            this.btn_Preporuka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Preporuka.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preporuka.ForeColor = System.Drawing.Color.White;
            this.btn_Preporuka.Image = global::wearther_desktop.Properties.Resources.refresh__1_;
            this.btn_Preporuka.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Preporuka.Location = new System.Drawing.Point(531, -1);
            this.btn_Preporuka.Name = "btn_Preporuka";
            this.btn_Preporuka.Size = new System.Drawing.Size(141, 77);
            this.btn_Preporuka.TabIndex = 29;
            this.btn_Preporuka.Text = "Preporuka";
            this.btn_Preporuka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Preporuka.UseVisualStyleBackColor = false;
            this.btn_Preporuka.Click += new System.EventHandler(this.Btn_Preporuka_Click);
            // 
            // img_Hlace
            // 
            this.img_Hlace.BackColor = System.Drawing.Color.Transparent;
            this.img_Hlace.Location = new System.Drawing.Point(341, 384);
            this.img_Hlace.Name = "img_Hlace";
            this.img_Hlace.Size = new System.Drawing.Size(180, 150);
            this.img_Hlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Hlace.TabIndex = 28;
            this.img_Hlace.TabStop = false;
            // 
            // img_Jakna
            // 
            this.img_Jakna.BackColor = System.Drawing.Color.Transparent;
            this.img_Jakna.Location = new System.Drawing.Point(555, 221);
            this.img_Jakna.Name = "img_Jakna";
            this.img_Jakna.Size = new System.Drawing.Size(180, 150);
            this.img_Jakna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Jakna.TabIndex = 27;
            this.img_Jakna.TabStop = false;
            // 
            // img_Obuca
            // 
            this.img_Obuca.BackColor = System.Drawing.Color.Transparent;
            this.img_Obuca.Location = new System.Drawing.Point(555, 384);
            this.img_Obuca.Name = "img_Obuca";
            this.img_Obuca.Size = new System.Drawing.Size(180, 150);
            this.img_Obuca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Obuca.TabIndex = 26;
            this.img_Obuca.TabStop = false;
            // 
            // img_Majica
            // 
            this.img_Majica.BackColor = System.Drawing.Color.Transparent;
            this.img_Majica.Location = new System.Drawing.Point(341, 221);
            this.img_Majica.Name = "img_Majica";
            this.img_Majica.Size = new System.Drawing.Size(180, 150);
            this.img_Majica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Majica.TabIndex = 25;
            this.img_Majica.TabStop = false;
            // 
            // btn_Unos
            // 
            this.btn_Unos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Unos.FlatAppearance.BorderSize = 0;
            this.btn_Unos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unos.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unos.ForeColor = System.Drawing.Color.White;
            this.btn_Unos.Image = global::wearther_desktop.Properties.Resources.tshirtqwe;
            this.btn_Unos.Location = new System.Drawing.Point(0, 277);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(253, 41);
            this.btn_Unos.TabIndex = 23;
            this.btn_Unos.Text = "Unos";
            this.btn_Unos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Unos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Unos.UseVisualStyleBackColor = false;
            this.btn_Unos.Click += new System.EventHandler(this.Btn_Unos_Click);
            // 
            // btn_Preporuke
            // 
            this.btn_Preporuke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Preporuke.FlatAppearance.BorderSize = 0;
            this.btn_Preporuke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preporuke.Font = new System.Drawing.Font("Dubai", 11.25F);
            this.btn_Preporuke.ForeColor = System.Drawing.Color.White;
            this.btn_Preporuke.Image = global::wearther_desktop.Properties.Resources.miniFashioncloud;
            this.btn_Preporuke.Location = new System.Drawing.Point(0, 159);
            this.btn_Preporuke.Name = "btn_Preporuke";
            this.btn_Preporuke.Size = new System.Drawing.Size(186, 45);
            this.btn_Preporuke.TabIndex = 41;
            this.btn_Preporuke.Text = "Preporuke";
            this.btn_Preporuke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Preporuke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Preporuke.UseVisualStyleBackColor = false;
            this.btn_Preporuke.Click += new System.EventHandler(this.Btn_Preporuke_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::wearther_desktop.Properties.Resources.Fashioncloud;
            this.pictureBox1.Location = new System.Drawing.Point(434, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Preporuke
            // 
            this.lbl_Preporuke.AutoSize = true;
            this.lbl_Preporuke.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Preporuke.Font = new System.Drawing.Font("Dubai Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preporuke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.lbl_Preporuke.Location = new System.Drawing.Point(487, 27);
            this.lbl_Preporuke.Name = "lbl_Preporuke";
            this.lbl_Preporuke.Size = new System.Drawing.Size(139, 49);
            this.lbl_Preporuke.TabIndex = 43;
            this.lbl_Preporuke.Text = "Preporuke";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rb_Snijeg);
            this.panel1.Controls.Add(this.btn_Preporuka);
            this.panel1.Controls.Add(this.rb_Sunce);
            this.panel1.Controls.Add(this.rb_Kisa);
            this.panel1.Location = new System.Drawing.Point(222, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 77);
            this.panel1.TabIndex = 44;
            // 
            // rb_Snijeg
            // 
            this.rb_Snijeg.BackColor = System.Drawing.Color.Transparent;
            this.rb_Snijeg.Image = global::wearther_desktop.Properties.Resources.snow;
            this.rb_Snijeg.Location = new System.Drawing.Point(426, 20);
            this.rb_Snijeg.Name = "rb_Snijeg";
            this.rb_Snijeg.Size = new System.Drawing.Size(70, 45);
            this.rb_Snijeg.TabIndex = 35;
            this.rb_Snijeg.TabStop = true;
            this.rb_Snijeg.UseVisualStyleBackColor = false;
            this.rb_Snijeg.CheckedChanged += new System.EventHandler(this.Rb_Snijeg_CheckedChanged);
            // 
            // lbl_Korisnik
            // 
            this.lbl_Korisnik.AutoSize = true;
            this.lbl_Korisnik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Korisnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.lbl_Korisnik.Location = new System.Drawing.Point(6, 582);
            this.lbl_Korisnik.Name = "lbl_Korisnik";
            this.lbl_Korisnik.Size = new System.Drawing.Size(60, 13);
            this.lbl_Korisnik.TabIndex = 45;
            this.lbl_Korisnik.Text = "lbl_Korisnik";
            // 
            // btn_Odjava
            // 
            this.btn_Odjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Odjava.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.btn_Odjava.ForeColor = System.Drawing.Color.White;
            this.btn_Odjava.Location = new System.Drawing.Point(913, 568);
            this.btn_Odjava.Name = "btn_Odjava";
            this.btn_Odjava.Size = new System.Drawing.Size(75, 27);
            this.btn_Odjava.TabIndex = 46;
            this.btn_Odjava.Text = "Odjava";
            this.btn_Odjava.UseVisualStyleBackColor = false;
            this.btn_Odjava.Click += new System.EventHandler(this.Btn_Odjava_Click);
            // 
            // btn_Ideja
            // 
            this.btn_Ideja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Ideja.FlatAppearance.BorderSize = 0;
            this.btn_Ideja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ideja.Font = new System.Drawing.Font("Dubai", 11.25F);
            this.btn_Ideja.ForeColor = System.Drawing.Color.White;
            this.btn_Ideja.Image = global::wearther_desktop.Properties.Resources.creativity;
            this.btn_Ideja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ideja.Location = new System.Drawing.Point(96, 392);
            this.btn_Ideja.Name = "btn_Ideja";
            this.btn_Ideja.Size = new System.Drawing.Size(103, 62);
            this.btn_Ideja.TabIndex = 47;
            this.btn_Ideja.Text = "Inspiracija";
            this.btn_Ideja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ideja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Ideja.UseVisualStyleBackColor = false;
            this.btn_Ideja.Click += new System.EventHandler(this.Btn_Ideja_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.panel2.BackgroundImage = global::wearther_desktop.Properties.Resources.mybbg;
            this.panel2.Controls.Add(this.img_Haljina);
            this.panel2.Location = new System.Drawing.Point(320, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 313);
            this.panel2.TabIndex = 48;
            // 
            // img_Haljina
            // 
            this.img_Haljina.BackColor = System.Drawing.Color.Transparent;
            this.img_Haljina.Location = new System.Drawing.Point(15, 37);
            this.img_Haljina.Name = "img_Haljina";
            this.img_Haljina.Size = new System.Drawing.Size(180, 236);
            this.img_Haljina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Haljina.TabIndex = 49;
            this.img_Haljina.TabStop = false;
            // 
            // cb_Haljina
            // 
            this.cb_Haljina.AutoSize = true;
            this.cb_Haljina.BackColor = System.Drawing.Color.Transparent;
            this.cb_Haljina.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.cb_Haljina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Haljina.Location = new System.Drawing.Point(759, 159);
            this.cb_Haljina.Name = "cb_Haljina";
            this.cb_Haljina.Size = new System.Drawing.Size(140, 26);
            this.cb_Haljina.TabIndex = 49;
            this.cb_Haljina.Text = "Haljina/Kombinezon";
            this.cb_Haljina.UseVisualStyleBackColor = false;
            // 
            // Preporuke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::wearther_desktop.Properties.Resources.pozadinasalogo2;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.cb_Haljina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Ideja);
            this.Controls.Add(this.btn_Odjava);
            this.Controls.Add(this.lbl_Korisnik);
            this.Controls.Add(this.lbl_Preporuke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Preporuke);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.btn_Ormar);
            this.Controls.Add(this.cb_Temp);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.img_Hlace);
            this.Controls.Add(this.img_Jakna);
            this.Controls.Add(this.img_Obuca);
            this.Controls.Add(this.img_Majica);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preporuke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preporuke";
            this.Load += new System.EventHandler(this.Preporuke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Hlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Jakna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Obuca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Majica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Haljina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_Unos;
        private System.Windows.Forms.Button btn_Ormar;
        private System.Windows.Forms.PictureBox img_Majica;
        private System.Windows.Forms.PictureBox img_Obuca;
        private System.Windows.Forms.PictureBox img_Jakna;
        private System.Windows.Forms.PictureBox img_Hlace;
        private System.Windows.Forms.Button btn_Preporuka;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.RadioButton rb_Sunce;
        private System.Windows.Forms.RadioButton rb_Kisa;
        private System.Windows.Forms.ComboBox cb_Temp;
        private System.Windows.Forms.Button btn_Preporuke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Preporuke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Korisnik;
        private System.Windows.Forms.Button btn_Odjava;
        private System.Windows.Forms.Button btn_Ideja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox img_Haljina;
        private System.Windows.Forms.CheckBox cb_Haljina;
        private System.Windows.Forms.RadioButton rb_Snijeg;
    }
}