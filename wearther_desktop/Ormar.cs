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
    public partial class Ormar : Form
    {
        DataTable dba;
        int idormar;
        public Ormar()
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

       

        private void Btn_Obrisi_Click(object sender, EventArgs e)
        {
            var con = DB.GetSQL();
            con.Open();
            try
            {
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[1].Value;
                MemoryStream ms = new MemoryStream();

                idormar = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM MojOrmar WHERE Id ='" + idormar + "';", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno obrisano!");
                this.Hide();
                Form Ormar = new Ormar();
                Ormar.Show();

            }
            catch (Exception)
            {
               
            }

          
        }

        
    

        private void Ormar_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowTemplate.MinimumHeight = 100;
            lbl_Korisnik.Text = TrenutniKorisnik.PrijavljeniKorisnik;

            pan_Ispis.Visible = false;
            var con = DB.GetSQL();
                con.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT Id, Image as Ormar FROM MojOrmar WHERE Korisnik= '"+lbl_Korisnik.Text+"' ;", con);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    dba = new DataTable();
                    sda.Fill(dba);

                    dataGridView1.RowTemplate.Height = 60;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.DataSource = dba;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    BindingSource source = new BindingSource();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    source.DataSource = dba;
                    dataGridView1.DataSource = source;
                    this.dataGridView1.Columns[0].Visible = false;
                    sda.Update(dba);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        


        }

        private void btn_Trazi_Click(object sender, EventArgs e)
        {
            var kon = DB.GetSQL();
            kon.Open();
            try { 
            idormar = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());       
            SqlDataAdapter sdata = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Id ='" + idormar + "';", kon);
            DataTable dt = new DataTable();
            sdata.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbl_Tip.Text = dt.Rows[0][1].ToString();
                lbl_Boja.Text = dt.Rows[0][2].ToString();
                lbl_Marka.Text = dt.Rows[0][3].ToString();
                lbl_Voda.Text = dt.Rows[0][4].ToString();
                lbl_Prigoda.Text = dt.Rows[0][5].ToString();
                lbl_Vrijeme0.Text = dt.Rows[0][7].ToString();
                lbl_Vrijeme1.Text = dt.Rows[0][8].ToString();
                lbl_Vrijeme2.Text = dt.Rows[0][9].ToString();
                lbl_Vrijeme3.Text = dt.Rows[0][10].ToString();
                lbl_Vrijeme4.Text = dt.Rows[0][11].ToString();
                Byte[] data = (Byte[])dt.Rows[0][6];
                MemoryStream mem = new MemoryStream(data);
                slikabox.Image = Image.FromStream(mem);
                kon.Close();
                    
                lbl_BojaJe.Text = "Boja: ";
                lbl_MarkaJe.Text = "Marka: ";
                lbl_PrigodaJe.Text = "Prigoda: ";
                pan_Ispis.Visible = true;
                }
            else
            {
                    MessageBox.Show("Ormar je prazan!");
                }
            }
            catch
            {
               
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

