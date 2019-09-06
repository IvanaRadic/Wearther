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
    public partial class Ideja : Form
    {
       
        string vrijemesk;

        public Ideja()
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


        private void Btn_Ormar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Ormar = new Ormar();
            Ormar.Show();
        }

        private void Btn_Preporuka_Click(object sender, EventArgs e)
        {
                if (rb_Sunce.Checked == false && rb_Kisa.Checked == false && rb_Snijeg.Checked == false || cb_Temp.Text == "")
                {
                    MessageBox.Show("Unesite sve podatke!");
                }
                else
                {
                    var con = DB.GetSQL();
                    con.Open();
                    //haljina ili kombinezon
                    if (cb_Haljina.Checked == true)
                    {
                        panel2.Visible = true;
                        //manje od 5
                        if (cb_Temp.Text == "<5°C")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Haljina/Kombinezon' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Haljina.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Haljina.Image = global::wearther_desktop.Properties.Resources.Empty;

                            }
                        }
                        //5-10°C
                        if (cb_Temp.Text == "5-10°C")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Haljina/Kombinezon' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Haljina.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Haljina.Image = global::wearther_desktop.Properties.Resources.Empty;

                            }
                        }
                        //10°C-20°C
                        if (cb_Temp.Text == "10-20°C")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Haljina/Kombinezon' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Haljina.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Haljina.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        //20 do 25
                        if (cb_Temp.Text == "20-25°C")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Haljina/Kombinezon' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Haljina.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Haljina.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        //25+
                        if (cb_Temp.Text == ">25°C")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Haljina/Kombinezon' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Haljina.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Haljina.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                    }
                    if (cb_Haljina.Checked == false)
                    {
                        panel2.Visible = false;
                    }
                    //manje od 5
                    if (cb_Temp.Text == "<5°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Majica' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Majica.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Majica.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "<5°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Hlace' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Hlace.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Hlace.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }


                    if (cb_Temp.Text == "<5°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Jakna' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Jakna' AND Privatnost = 'Javno' ;", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    if (cb_Temp.Text == "<5°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Obuca' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme0 = '<5°C' AND Tip = 'Obuca' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    //5-10°C
                    if (cb_Temp.Text == "5-10°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Majica' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Majica.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Majica.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "5-10°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Hlace' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Hlace.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Hlace.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "5-10°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Jakna' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Jakna' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    if (cb_Temp.Text == "5-10°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Obuca' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme1 = '5-10°C' AND Tip = 'Obuca' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    //10-20°C
                    if (cb_Temp.Text == "10-20°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Majica' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Majica.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Majica.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "10-20°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Hlace' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Hlace.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Hlace.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "10-20°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Jakna' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Jakna' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    if (cb_Temp.Text == "10-20°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Obuca' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme2 = '10-20°C' AND Tip = 'Obuca' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                    }
                    //od 20 do 25
                    if (cb_Temp.Text == "20-25°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Majica' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Majica.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Majica.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "20-25°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Hlace' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Hlace.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Hlace.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == "20-25°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Jakna' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Jakna' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }

                    }
                    if (cb_Temp.Text == "20-25°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Obuca' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme3 = '20-25°C' AND Tip = 'Obuca' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                    }
                    //25+
                    if (cb_Temp.Text == ">25°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Majica' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Majica.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Majica.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == ">25°C")
                    {
                        SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Hlace' AND Privatnost = 'Javno';", con);
                        DataTable datat = new DataTable();
                        sdatar.Fill(datat);
                        if (datat.Rows.Count > 0)
                        {
                            Random rnd = new Random();
                            int i = rnd.Next(0, datat.Rows.Count);

                            Byte[] data = (Byte[])datat.Rows[i][6];
                            MemoryStream mem = new MemoryStream(data);
                            img_Hlace.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            this.img_Hlace.Image = global::wearther_desktop.Properties.Resources.Empty;
                        }
                    }
                    if (cb_Temp.Text == ">25°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Jakna' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Jakna' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Jakna.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Jakna.Image = global::wearther_desktop.Properties.Resources.Empty;

                            }
                        }

                    }
                    if (cb_Temp.Text == ">25°C")
                    {
                        if (vrijemesk == "Kisa" || vrijemesk == "Snijeg")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Obuca' AND Voda = 'Vodootporno' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                        else if (vrijemesk == "Sunce")
                        {
                            SqlDataAdapter sdatar = new SqlDataAdapter("SELECT * FROM MojOrmar WHERE Vrijeme4 = '>25°C' AND Tip = 'Obuca' AND Privatnost = 'Javno';", con);
                            DataTable datat = new DataTable();
                            sdatar.Fill(datat);
                            if (datat.Rows.Count > 0)
                            {
                                Random rnd = new Random();
                                int i = rnd.Next(0, datat.Rows.Count);

                                Byte[] data = (Byte[])datat.Rows[i][6];
                                MemoryStream mem = new MemoryStream(data);
                                img_Obuca.Image = Image.FromStream(mem);
                            }
                            else
                            {
                                this.img_Obuca.Image = global::wearther_desktop.Properties.Resources.Empty;
                            }
                        }
                    }
                    con.Close();
                }

            
        }


        private void Rb_Sunce_CheckedChanged(object sender, EventArgs e)
        {
            vrijemesk = "Sunce";
        }

        private void Rb_Kisa_CheckedChanged(object sender, EventArgs e)
        {
            vrijemesk = "Kisa";
        }
        private void Rb_Snijeg_CheckedChanged(object sender, EventArgs e)
        {
            vrijemesk = "Snijeg";
        }

        private void Btn_Preporuke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Preporuke = new Preporuke();
            Preporuke.Show();
        }

        private void Btn_Unos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Unos = new Unos();
            Unos.Show();
        }

        private void Preporuke_Load(object sender, EventArgs e)
        {
            lbl_Korisnik.Text = TrenutniKorisnik.PrijavljeniKorisnik;
            panel2.Visible = false;
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

        private void Cb_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Temp.Text != "<5°C")
            {
                rb_Snijeg.Enabled = false;
                rb_Snijeg.Checked = false;
            }
            else
            {
                rb_Snijeg.Enabled = true;
            }
        }

     
    }
}
