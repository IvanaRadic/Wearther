using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wearther_desktop.Model;

namespace wearther_desktop
{
    public partial class Unos : Form
    {
        string voda;
        string vrijeme0;
        string vrijeme1;
        string vrijeme2;
        string vrijeme3;
        string vrijeme4;
        string privatnost;



        public Unos()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        string imgLocation = "";
        SqlCommand cmd;
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files (*.jpg) |*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                slikabox.ImageLocation = imgLocation;
            }
        }

      

        private void Btn_Spremi_Click(object sender, EventArgs e)
        {
            var con = DB.GetSQL();
            con.Open();
            if (cb_Voda.Checked == true && cb_Tip.Text != "Majica" && cb_Tip.Text != "Hlače" && cb_Tip.Text != "Haljina/Kombinezon") {
                voda = "Vodootporno";
            }
           

            if (rb_Privatno.Checked == true)
            {
                privatnost = "Privatno";
            }
            if (rb_Javno.Checked == true)
            {
                privatnost = "Javno";
            }

            if (cb_Vrijeme0.Checked == true)
            {
                vrijeme0 = cb_Vrijeme0.Text;
            }
            else if (cb_Vrijeme0.Checked == false)
            {
                vrijeme0 = "";
            }

            if (cb_Vrijeme1.Checked == true)
            {
                vrijeme1 = cb_Vrijeme1.Text;
            }
            else if (cb_Vrijeme1.Checked == false){             
                vrijeme1 = "";
            }
            if (cb_Vrijeme2.Checked == true)
            {
                vrijeme2 = cb_Vrijeme2.Text;
            }
            else if (cb_Vrijeme2.Checked == false)
            {
                vrijeme2 = "";
            }
            if (cb_Vrijeme3.Checked == true)
            {
                vrijeme3 = cb_Vrijeme3.Text;
            }
            else if (cb_Vrijeme3.Checked == false)
            {
                vrijeme3 = "";
            }
            if (cb_Vrijeme4.Checked == true)
            {
                vrijeme4 = cb_Vrijeme4.Text;
            }
            else if (cb_Vrijeme4.Checked == false)
            {
                vrijeme4 = "";
            }
            if (cb_Tip.Text == "" || cb_Boja.Text == "" || tb_Marka.Text == "" || cb_Prigoda.Text == "" || vrijeme0 != cb_Vrijeme0.Text && vrijeme1 != cb_Vrijeme1.Text && vrijeme2 != cb_Vrijeme2.Text && vrijeme3 != cb_Vrijeme3.Text && vrijeme4 != cb_Vrijeme4.Text || rb_Privatno.Checked == false && rb_Javno.Checked == false)
            {
                    MessageBox.Show("Unesite sva polja!");       
            }
           
            else
                {              
               byte[] images = null;
                if (imgLocation == "")
                {
                    MessageBox.Show("Unesite sliku!");
                }

                else
                {
                    
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);

                   

                    string query = "INSERT INTO MojOrmar(Tip, Boja, Marka, Voda, Prigoda, Vrijeme0, Vrijeme1, Vrijeme2, Vrijeme3, Vrijeme4, Korisnik, Privatnost, Image) " +
                       "VALUES " + "('" + cb_Tip.Text + "', '" + cb_Boja.Text + "','" + tb_Marka.Text + "' ,'" + voda + "','" + cb_Prigoda.Text + "','" + vrijeme0 + "','" + vrijeme1 + "','" + vrijeme2 + "','" + vrijeme3 + "','" + vrijeme4 + "','" + lbl_Korisnik.Text + "','" + privatnost + "',@images)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Form Ormar = new Ormar();
                    Ormar.Show();


                }

                con.Close();
            }
        }


        private void Cb_Tip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Tip.Text == "Majica" || cb_Tip.Text == "Hlače" || cb_Tip.Text == "Haljina/Kombinezon")
            {
                cb_Voda.Enabled = false;
            }
            else
            {
                cb_Voda.Enabled = true;
            }
        }

        private void Btn_Preporuke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Preporuke = new Preporuke();
            Preporuke.Show();
        }

        private void Btn_Ormar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Ormar = new Ormar();
            Ormar.Show();
        }

        private void Btn_Unos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Unos = new Unos();
            Unos.Show();
        }

        private void Unos_Load(object sender, EventArgs e)
        {
            lbl_Korisnik.Text = TrenutniKorisnik.PrijavljeniKorisnik;

        }

        private void Btn_Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Prijava = new Prijava();
            Prijava.Show();
        }

        private void Btn_Ideja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Ideja = new Ideja();
            Ideja.Show();
        }

    }
}
    
