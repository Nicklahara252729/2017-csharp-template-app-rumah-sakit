using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_RUMAH_SAKIT
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Mouse Drag Form
        private bool mouseDown;
        private Point lastLocation;

        private void FrmLogin_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmLogin_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FrmLogin_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void PctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (RbAdmin.Checked == false && RbDokter.Checked == false)
            {
                MessageBox.Show("Hak akses belum di pilih !", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (RbAdmin.Checked == true)
            {
                if (TxtUsername.Text != "" && TxtPassword.Text != "")
                {
                    try
                    {
                        string hasil = "";
                        using (OracleConnection conn = new OracleConnection
                        ("User ID= dbrs" + ";Password=dbrs" + ";Data Source='XE" + "';"))
                        using (OracleCommand cmd = new OracleCommand
                        ("SELECT * from TBLUSER where ID='" + TxtUsername.Text + "'AND leveluser='admin" + "'", conn))
                        {
                            conn.Open();
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    hasil = reader["PASSWORD"].ToString();
                                    if (TxtPassword.Text == hasil)
                                    {
                                        string kiriman;
                                        kiriman = TxtUsername.Text;
                                        FrmAdmin admin = new FrmAdmin(kiriman);
                                        this.Hide();
                                        admin.ShowDialog();
                                    }
                                    else
                                    { MessageBox.Show("ID tidak terdaftar/ Password salah"); }
                                }
                                if (hasil == "")
                                {
                                    DialogResult dialogResult = MessageBox.Show("Kode/Password Salah, Periksa Kembali",
                                        "WARNING", MessageBoxButtons.OK);

                                    BtnCancel_Click(sender, e);
                                    this.ActiveControl = TxtUsername;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (RbDokter.Checked == true)
            {
                try
                {
                    string hasil = "";
                    using (OracleConnection conn = new OracleConnection
                    ("User ID= dbrs" + ";Password=dbrs" + ";Data Source='XE" + "';"))
                    using (OracleCommand cmd = new OracleCommand
                    ("SELECT * from TBLUSER where ID='" + TxtUsername.Text + "'AND leveluser='dokter" + "'", conn))
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hasil = reader["PASSWORD"].ToString();
                                if (TxtPassword.Text == hasil)
                                {
                                    string kiriman;
                                    kiriman = TxtUsername.Text;
                                    FrmDokter admin = new FrmDokter(kiriman);
                                    this.Hide();
                                    admin.ShowDialog();
                                }
                                else
                                { MessageBox.Show("ID/ Password Salah!"); }
                            }
                            if (hasil == "")
                            {
                                DialogResult dialogResult = MessageBox.Show("Kode/Password Salah, Periksa Kembali",
                                    "WARNING", MessageBoxButtons.OK);

                                BtnCancel_Click(sender, e);
                                this.ActiveControl = TxtUsername;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            { MessageBox.Show("Inputan tidak lengkap !", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
        }
    }
}
