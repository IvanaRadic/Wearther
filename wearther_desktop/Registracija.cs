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
using System.Text.RegularExpressions;

namespace wearther_desktop
{
    public partial class Registracija : Form
    {
        public Registracija()
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

        private void Tb_Email2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            var con = DB.GetSQL();
            con.Open();


            if (tb_Name.Text == "" || tb_LastName.Text == "" || tb_Email2.Text == "" || tb_Password2.Text == "")
            {
                MessageBox.Show("Popunite sva polja!");
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Korisnik] WHERE Email_korisnika = @email ", con);
                command.Parameters.AddWithValue("@email", tb_Email2.Text);
                object vrijednost = command.ExecuteScalar();
                int Provjera = Convert.ToInt32(vrijednost);
                if (Provjera > 0)
                {
                    MessageBox.Show("Korisnik već postoji!");
                }
                else
                {
                    string unos = "INSERT INTO Korisnik (Email_korisnika, Ime_korisnika, Prezime_korisnika, Lozinka_korisnika) VALUES" +
                                    "('" + tb_Email2.Text + "','" + tb_Name.Text + "','" + tb_LastName.Text + "','" + tb_Password2.Text + "' )";
                    SqlCommand sqlcomm = new SqlCommand(unos, con);
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Uspješno ste se registrirali, prijavite se!");
                    this.Hide();
                    Form Prijava = new Prijava();
                    Prijava.Show();
                }
            }

            con.Close();
        }

        private void Lbl_RegisterPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Prijava = new Prijava();
            Prijava.Show();
        }
        private void Tb_Email_Leave(object sender, EventArgs e)
        {
            string pattern = (@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (Regex.IsMatch(tb_Email2.Text, pattern))
            {

            }
            else
            {
                MessageBox.Show("Unesite ispravnu E-mail adresu!");
                tb_Email2.Focus();
            }
        }
    }
   
}
