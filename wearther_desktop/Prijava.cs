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
using wearther_desktop.Model;
using System.Text.RegularExpressions;

namespace wearther_desktop
{
    public partial class Prijava : Form
    {
        public Prijava()
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

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {   
            var con = DB.GetSQL();
            con.Open();
            if (tb_Email.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Popunite sva polja!");
            }
            else
            {
                string podaci = "SELECT Ime_Korisnika, Email_korisnika , Lozinka_korisnika FROM Korisnik  WHERE Email_korisnika = '" + tb_Email.Text + "' AND Lozinka_korisnika = '" + tb_Password.Text + "';";

                SqlCommand trazi = new SqlCommand(podaci, con);
                SqlDataReader citaj = trazi.ExecuteReader();
                if (citaj.Read())
                {
                    TrenutniKorisnik.PrijavljeniKorisnik = (string)citaj["Email_Korisnika"];
                    TrenutniKorisnik.ImeKorisnika = (string)citaj["Ime_Korisnika"];
                    string korisnik = TrenutniKorisnik.ImeKorisnika;
                    MessageBox.Show("Dobrodošli, "+korisnik+"");
                    Form Preporuke = new Preporuke();
                    Preporuke.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Email ili lozinka su netočni!");
                }
            }
            con.Close();
        }

        private void Lbl_RegisterPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Registracija = new Registracija();
            Registracija.Show();
        }
 
    }
}
