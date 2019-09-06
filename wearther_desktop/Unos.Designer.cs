namespace wearther_desktop
{
    partial class Unos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unos));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.cb_Tip = new System.Windows.Forms.ComboBox();
            this.cb_Boja = new System.Windows.Forms.ComboBox();
            this.lbl_Boja = new System.Windows.Forms.Label();
            this.lbl_Vrijeme = new System.Windows.Forms.Label();
            this.tb_Marka = new System.Windows.Forms.TextBox();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.slikabox = new System.Windows.Forms.PictureBox();
            this.lbl_Prigoda = new System.Windows.Forms.Label();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.cb_Prigoda = new System.Windows.Forms.ComboBox();
            this.cb_Vrijeme1 = new System.Windows.Forms.CheckBox();
            this.cb_Vrijeme2 = new System.Windows.Forms.CheckBox();
            this.cb_Vrijeme3 = new System.Windows.Forms.CheckBox();
            this.cb_Vrijeme4 = new System.Windows.Forms.CheckBox();
            this.btn_Preporuke = new System.Windows.Forms.Button();
            this.btn_Ormar = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.lbl_Preporuke = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Odjava = new System.Windows.Forms.Button();
            this.lbl_Korisnik = new System.Windows.Forms.Label();
            this.rb_Javno = new System.Windows.Forms.RadioButton();
            this.rb_Privatno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Ideja = new System.Windows.Forms.Button();
            this.cb_Vrijeme0 = new System.Windows.Forms.CheckBox();
            this.cb_Voda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikabox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tip.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.lbl_Tip.Location = new System.Drawing.Point(550, 166);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(26, 17);
            this.lbl_Tip.TabIndex = 23;
            this.lbl_Tip.Text = "Tip";
            // 
            // cb_Tip
            // 
            this.cb_Tip.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tip.FormattingEnabled = true;
            this.cb_Tip.Items.AddRange(new object[] {
            "Obuća",
            "Majica",
            "Hlače",
            "Jakna",
            "Haljina/Kombinezon"});
            this.cb_Tip.Location = new System.Drawing.Point(616, 163);
            this.cb_Tip.Name = "cb_Tip";
            this.cb_Tip.Size = new System.Drawing.Size(121, 25);
            this.cb_Tip.TabIndex = 24;
            this.cb_Tip.SelectedIndexChanged += new System.EventHandler(this.Cb_Tip_SelectedIndexChanged);
            // 
            // cb_Boja
            // 
            this.cb_Boja.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Boja.FormattingEnabled = true;
            this.cb_Boja.Items.AddRange(new object[] {
            "Crna",
            "Siva",
            "Bijela",
            "Žuta",
            "Narančasta",
            "Crvena",
            "Roza",
            "Ljubičasta",
            "Plava",
            "Zelena",
            "Smeđa"});
            this.cb_Boja.Location = new System.Drawing.Point(616, 205);
            this.cb_Boja.Name = "cb_Boja";
            this.cb_Boja.Size = new System.Drawing.Size(121, 25);
            this.cb_Boja.TabIndex = 26;
            // 
            // lbl_Boja
            // 
            this.lbl_Boja.AutoSize = true;
            this.lbl_Boja.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Boja.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.lbl_Boja.Location = new System.Drawing.Point(550, 208);
            this.lbl_Boja.Name = "lbl_Boja";
            this.lbl_Boja.Size = new System.Drawing.Size(33, 17);
            this.lbl_Boja.TabIndex = 25;
            this.lbl_Boja.Text = "Boja";
            // 
            // lbl_Vrijeme
            // 
            this.lbl_Vrijeme.AutoSize = true;
            this.lbl_Vrijeme.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vrijeme.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.lbl_Vrijeme.Location = new System.Drawing.Point(566, 353);
            this.lbl_Vrijeme.Name = "lbl_Vrijeme";
            this.lbl_Vrijeme.Size = new System.Drawing.Size(353, 17);
            this.lbl_Vrijeme.TabIndex = 27;
            this.lbl_Vrijeme.Text = "Označite na kojoj se temperaturi nosi ovaj odjevni predmet";
            // 
            // tb_Marka
            // 
            this.tb_Marka.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Marka.Location = new System.Drawing.Point(616, 250);
            this.tb_Marka.Name = "tb_Marka";
            this.tb_Marka.Size = new System.Drawing.Size(121, 25);
            this.tb_Marka.TabIndex = 29;
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marka.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.lbl_Marka.Location = new System.Drawing.Point(550, 253);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(45, 17);
            this.lbl_Marka.TabIndex = 30;
            this.lbl_Marka.Text = "Marka";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Browse.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Image = global::wearther_desktop.Properties.Resources.photo_camera;
            this.btn_Browse.Location = new System.Drawing.Point(364, 147);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(125, 45);
            this.btn_Browse.TabIndex = 37;
            this.btn_Browse.Text = "Učitaj fotografiju";
            this.btn_Browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // slikabox
            // 
            this.slikabox.BackColor = System.Drawing.Color.Transparent;
            this.slikabox.Location = new System.Drawing.Point(328, 200);
            this.slikabox.Name = "slikabox";
            this.slikabox.Size = new System.Drawing.Size(197, 239);
            this.slikabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikabox.TabIndex = 38;
            this.slikabox.TabStop = false;
            // 
            // lbl_Prigoda
            // 
            this.lbl_Prigoda.AutoSize = true;
            this.lbl_Prigoda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prigoda.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.lbl_Prigoda.Location = new System.Drawing.Point(550, 297);
            this.lbl_Prigoda.Name = "lbl_Prigoda";
            this.lbl_Prigoda.Size = new System.Drawing.Size(54, 17);
            this.lbl_Prigoda.TabIndex = 39;
            this.lbl_Prigoda.Text = "Prigoda";
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Spremi.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btn_Spremi.ForeColor = System.Drawing.Color.White;
            this.btn_Spremi.Location = new System.Drawing.Point(886, 457);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(75, 39);
            this.btn_Spremi.TabIndex = 40;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = false;
            this.btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
            // 
            // cb_Prigoda
            // 
            this.cb_Prigoda.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Prigoda.FormattingEnabled = true;
            this.cb_Prigoda.Items.AddRange(new object[] {
            "Svakidašnja",
            "Sportska",
            "Svečana"});
            this.cb_Prigoda.Location = new System.Drawing.Point(616, 294);
            this.cb_Prigoda.Name = "cb_Prigoda";
            this.cb_Prigoda.Size = new System.Drawing.Size(121, 25);
            this.cb_Prigoda.TabIndex = 41;
            // 
            // cb_Vrijeme1
            // 
            this.cb_Vrijeme1.AutoSize = true;
            this.cb_Vrijeme1.BackColor = System.Drawing.Color.Transparent;
            this.cb_Vrijeme1.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Vrijeme1.Location = new System.Drawing.Point(617, 384);
            this.cb_Vrijeme1.Name = "cb_Vrijeme1";
            this.cb_Vrijeme1.Size = new System.Drawing.Size(66, 21);
            this.cb_Vrijeme1.TabIndex = 44;
            this.cb_Vrijeme1.Text = "5-10°C";
            this.cb_Vrijeme1.UseVisualStyleBackColor = false;
            // 
            // cb_Vrijeme2
            // 
            this.cb_Vrijeme2.AutoSize = true;
            this.cb_Vrijeme2.BackColor = System.Drawing.Color.Transparent;
            this.cb_Vrijeme2.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Vrijeme2.Location = new System.Drawing.Point(695, 384);
            this.cb_Vrijeme2.Name = "cb_Vrijeme2";
            this.cb_Vrijeme2.Size = new System.Drawing.Size(73, 21);
            this.cb_Vrijeme2.TabIndex = 45;
            this.cb_Vrijeme2.Text = "10-20°C";
            this.cb_Vrijeme2.UseVisualStyleBackColor = false;
            // 
            // cb_Vrijeme3
            // 
            this.cb_Vrijeme3.AutoSize = true;
            this.cb_Vrijeme3.BackColor = System.Drawing.Color.Transparent;
            this.cb_Vrijeme3.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Vrijeme3.Location = new System.Drawing.Point(789, 384);
            this.cb_Vrijeme3.Name = "cb_Vrijeme3";
            this.cb_Vrijeme3.Size = new System.Drawing.Size(73, 21);
            this.cb_Vrijeme3.TabIndex = 46;
            this.cb_Vrijeme3.Text = "20-25°C";
            this.cb_Vrijeme3.UseVisualStyleBackColor = false;
            // 
            // cb_Vrijeme4
            // 
            this.cb_Vrijeme4.AutoSize = true;
            this.cb_Vrijeme4.BackColor = System.Drawing.Color.Transparent;
            this.cb_Vrijeme4.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Vrijeme4.Location = new System.Drawing.Point(884, 384);
            this.cb_Vrijeme4.Name = "cb_Vrijeme4";
            this.cb_Vrijeme4.Size = new System.Drawing.Size(63, 21);
            this.cb_Vrijeme4.TabIndex = 47;
            this.cb_Vrijeme4.Text = ">25°C";
            this.cb_Vrijeme4.UseVisualStyleBackColor = false;
            // 
            // btn_Preporuke
            // 
            this.btn_Preporuke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Preporuke.FlatAppearance.BorderSize = 0;
            this.btn_Preporuke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preporuke.Font = new System.Drawing.Font("Dubai", 11.25F);
            this.btn_Preporuke.ForeColor = System.Drawing.Color.White;
            this.btn_Preporuke.Image = global::wearther_desktop.Properties.Resources.miniFashioncloud;
            this.btn_Preporuke.Location = new System.Drawing.Point(0, 160);
            this.btn_Preporuke.Name = "btn_Preporuke";
            this.btn_Preporuke.Size = new System.Drawing.Size(143, 43);
            this.btn_Preporuke.TabIndex = 48;
            this.btn_Preporuke.Text = "Preporuke";
            this.btn_Preporuke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Preporuke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Preporuke.UseVisualStyleBackColor = false;
            this.btn_Preporuke.Click += new System.EventHandler(this.Btn_Preporuke_Click);
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
            this.btn_Ormar.TabIndex = 49;
            this.btn_Ormar.Text = "Ormar";
            this.btn_Ormar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ormar.UseVisualStyleBackColor = false;
            this.btn_Ormar.Click += new System.EventHandler(this.Btn_Ormar_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Unos.FlatAppearance.BorderSize = 0;
            this.btn_Unos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unos.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unos.ForeColor = System.Drawing.Color.White;
            this.btn_Unos.Image = global::wearther_desktop.Properties.Resources.tshirtqwe;
            this.btn_Unos.Location = new System.Drawing.Point(0, 276);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(291, 45);
            this.btn_Unos.TabIndex = 50;
            this.btn_Unos.Text = "Unos";
            this.btn_Unos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Unos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Unos.UseVisualStyleBackColor = false;
            this.btn_Unos.Click += new System.EventHandler(this.Btn_Unos_Click);
            // 
            // lbl_Preporuke
            // 
            this.lbl_Preporuke.AutoSize = true;
            this.lbl_Preporuke.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Preporuke.Font = new System.Drawing.Font("Dubai Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preporuke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.lbl_Preporuke.Location = new System.Drawing.Point(487, 27);
            this.lbl_Preporuke.Name = "lbl_Preporuke";
            this.lbl_Preporuke.Size = new System.Drawing.Size(82, 49);
            this.lbl_Preporuke.TabIndex = 52;
            this.lbl_Preporuke.Text = "Unos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::wearther_desktop.Properties.Resources.tshirtvel;
            this.pictureBox1.Location = new System.Drawing.Point(434, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Odjava
            // 
            this.btn_Odjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.btn_Odjava.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.btn_Odjava.ForeColor = System.Drawing.Color.White;
            this.btn_Odjava.Location = new System.Drawing.Point(913, 568);
            this.btn_Odjava.Name = "btn_Odjava";
            this.btn_Odjava.Size = new System.Drawing.Size(75, 27);
            this.btn_Odjava.TabIndex = 53;
            this.btn_Odjava.Text = "Odjava";
            this.btn_Odjava.UseVisualStyleBackColor = false;
            this.btn_Odjava.Click += new System.EventHandler(this.Btn_Odjava_Click);
            // 
            // lbl_Korisnik
            // 
            this.lbl_Korisnik.AutoSize = true;
            this.lbl_Korisnik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Korisnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.lbl_Korisnik.Location = new System.Drawing.Point(6, 582);
            this.lbl_Korisnik.Name = "lbl_Korisnik";
            this.lbl_Korisnik.Size = new System.Drawing.Size(60, 13);
            this.lbl_Korisnik.TabIndex = 54;
            this.lbl_Korisnik.Text = "lbl_Korisnik";
            // 
            // rb_Javno
            // 
            this.rb_Javno.AutoSize = true;
            this.rb_Javno.BackColor = System.Drawing.Color.Transparent;
            this.rb_Javno.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.rb_Javno.Location = new System.Drawing.Point(24, 66);
            this.rb_Javno.Name = "rb_Javno";
            this.rb_Javno.Size = new System.Drawing.Size(59, 21);
            this.rb_Javno.TabIndex = 55;
            this.rb_Javno.TabStop = true;
            this.rb_Javno.Text = "Javno";
            this.rb_Javno.UseVisualStyleBackColor = false;
            // 
            // rb_Privatno
            // 
            this.rb_Privatno.AutoSize = true;
            this.rb_Privatno.BackColor = System.Drawing.Color.Transparent;
            this.rb_Privatno.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.rb_Privatno.Location = new System.Drawing.Point(105, 66);
            this.rb_Privatno.Name = "rb_Privatno";
            this.rb_Privatno.Size = new System.Drawing.Size(73, 21);
            this.rb_Privatno.TabIndex = 56;
            this.rb_Privatno.TabStop = true;
            this.rb_Privatno.Text = "Privatno";
            this.rb_Privatno.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kako želite da ovaj odjevni\r\n predmet bude prikazan?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_Javno);
            this.panel1.Controls.Add(this.rb_Privatno);
            this.panel1.Location = new System.Drawing.Point(761, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 58;
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
            this.btn_Ideja.TabIndex = 59;
            this.btn_Ideja.Text = "Inspiracija";
            this.btn_Ideja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ideja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Ideja.UseVisualStyleBackColor = false;
            this.btn_Ideja.Click += new System.EventHandler(this.Btn_Ideja_Click);
            // 
            // cb_Vrijeme0
            // 
            this.cb_Vrijeme0.AutoSize = true;
            this.cb_Vrijeme0.BackColor = System.Drawing.Color.Transparent;
            this.cb_Vrijeme0.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Vrijeme0.Location = new System.Drawing.Point(555, 384);
            this.cb_Vrijeme0.Name = "cb_Vrijeme0";
            this.cb_Vrijeme0.Size = new System.Drawing.Size(56, 21);
            this.cb_Vrijeme0.TabIndex = 64;
            this.cb_Vrijeme0.Text = "<5°C";
            this.cb_Vrijeme0.UseVisualStyleBackColor = false;
            // 
            // cb_Voda
            // 
            this.cb_Voda.BackColor = System.Drawing.Color.Transparent;
            this.cb_Voda.Font = new System.Drawing.Font("Ebrima", 9.749999F);
            this.cb_Voda.Image = global::wearther_desktop.Properties.Resources.drop;
            this.cb_Voda.Location = new System.Drawing.Point(786, 166);
            this.cb_Voda.Name = "cb_Voda";
            this.cb_Voda.Size = new System.Drawing.Size(153, 42);
            this.cb_Voda.TabIndex = 65;
            this.cb_Voda.Text = "Vodootporno";
            this.cb_Voda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cb_Voda.UseVisualStyleBackColor = false;
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::wearther_desktop.Properties.Resources.pozadinasalogo2;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.cb_Voda);
            this.Controls.Add(this.cb_Vrijeme0);
            this.Controls.Add(this.btn_Ideja);
            this.Controls.Add(this.lbl_Korisnik);
            this.Controls.Add(this.btn_Odjava);
            this.Controls.Add(this.lbl_Preporuke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.btn_Ormar);
            this.Controls.Add(this.btn_Preporuke);
            this.Controls.Add(this.cb_Vrijeme4);
            this.Controls.Add(this.cb_Vrijeme3);
            this.Controls.Add(this.cb_Vrijeme2);
            this.Controls.Add(this.cb_Vrijeme1);
            this.Controls.Add(this.cb_Prigoda);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.lbl_Prigoda);
            this.Controls.Add(this.slikabox);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_Marka);
            this.Controls.Add(this.tb_Marka);
            this.Controls.Add(this.lbl_Vrijeme);
            this.Controls.Add(this.cb_Boja);
            this.Controls.Add(this.lbl_Boja);
            this.Controls.Add(this.cb_Tip);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos";
            this.Load += new System.EventHandler(this.Unos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikabox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.ComboBox cb_Tip;
        private System.Windows.Forms.ComboBox cb_Boja;
        private System.Windows.Forms.Label lbl_Boja;
        private System.Windows.Forms.Label lbl_Vrijeme;
        private System.Windows.Forms.TextBox tb_Marka;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox slikabox;
        private System.Windows.Forms.Label lbl_Prigoda;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.ComboBox cb_Prigoda;
        private System.Windows.Forms.CheckBox cb_Vrijeme1;
        private System.Windows.Forms.CheckBox cb_Vrijeme2;
        private System.Windows.Forms.CheckBox cb_Vrijeme3;
        private System.Windows.Forms.CheckBox cb_Vrijeme4;
        private System.Windows.Forms.Button btn_Preporuke;
        private System.Windows.Forms.Button btn_Ormar;
        private System.Windows.Forms.Button btn_Unos;
        private System.Windows.Forms.Label lbl_Preporuke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Odjava;
        private System.Windows.Forms.Label lbl_Korisnik;
        private System.Windows.Forms.RadioButton rb_Javno;
        private System.Windows.Forms.RadioButton rb_Privatno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ideja;
        private System.Windows.Forms.CheckBox cb_Vrijeme0;
        private System.Windows.Forms.CheckBox cb_Voda;
    }
}