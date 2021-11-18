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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();

            _UcWelcome();// Memanggil User Control Kalimat -WELCOME-

            BtnDashboard.ForeColor = Color.MediumTurquoise; // Mengubah warna fore color button Dashboard
        }

        public FrmAdmin(string terima)
            : this()
        {
            LblNamaAdmin.Text = terima;
        }

        #region From Drag (Source Code Supaya Form bisa di pindahkan)
        private bool mouseDown;
        private Point lastLocation;

        private void FrmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FrmAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void PctClose_Click(object sender, EventArgs e)
        {
            FrmLogin GoLogin = new FrmLogin();
            GoLogin.Show();
            this.Hide();
        }

        private void PctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private readonly UcWelcome _myUcWelcome = new UcWelcome { Dock = DockStyle.Fill };
        private readonly UcDokter _myUcDokter = new UcDokter { Dock = DockStyle.Fill };
        private readonly UcPasien _myUcPasien = new UcPasien { Dock = DockStyle.Fill };
        private readonly UcObat _myUcObat = new UcObat { Dock = DockStyle.Fill };
        private readonly UcPengobatan _myUcPengobatan = new UcPengobatan { Dock = DockStyle.Fill };

        public void _UcWelcome()
        {
            //Source Code untuk memanggil User Control Welcome
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcWelcome))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcWelcome);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;
            //--------------------------------------------------
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Dashboard";
            _UcWelcome();

            BtnDashboard.ForeColor = Color.MediumTurquoise;
            BtnDokter.ForeColor = Color.White;
            BtnPasien.ForeColor = Color.White;
            BtnObat.ForeColor = Color.White;
            BtnPengobatan.ForeColor = Color.White;
        }

        private void BtnDokter_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Kelola Data Dokter";
            //Source Code untuk memanggil User Control Dokter
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcDokter))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcDokter);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;
            //--------------------------------------------------

            BtnDashboard.ForeColor = Color.White;
            BtnDokter.ForeColor = Color.LimeGreen;
            BtnPasien.ForeColor = Color.White;
            BtnObat.ForeColor = Color.White;
            BtnPengobatan.ForeColor = Color.White;
        }

        private void BtnPasien_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Kelola Data Pasien";
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcPasien))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcPasien);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;

            BtnDashboard.ForeColor = Color.White;
            BtnDokter.ForeColor = Color.White;
            BtnPasien.ForeColor = Color.DarkCyan;
            BtnObat.ForeColor = Color.White;
            BtnPengobatan.ForeColor = Color.White;
        }

        private void BtnObat_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Kelola Data Obat";
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcObat))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcObat);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;

            BtnDashboard.ForeColor = Color.White;
            BtnDokter.ForeColor = Color.White;
            BtnPasien.ForeColor = Color.White;
            BtnObat.ForeColor = Color.Tomato;
            BtnPengobatan.ForeColor = Color.White;
        }

        private void BtnPengobatan_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Menentukan Dokter yang mengobati pasien";
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcPengobatan))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcPengobatan);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;

            BtnDashboard.ForeColor = Color.White;
            BtnDokter.ForeColor = Color.White;
            BtnPasien.ForeColor = Color.White;
            BtnObat.ForeColor = Color.White;
            BtnPengobatan.ForeColor = Color.LightSeaGreen;
        }

        

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ShowDokter();
            ShowPasien();

        }

        public void ShowDokter()
        {
            try
            {
                var kon = Koneksi_DB.GetOracleConnection();
                using(OracleCommand cmd = new OracleCommand
                    ("select * from tbldokter", kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                            DataTable data = new DataTable();
                            data.Load(reader);
                            DgvDokter.DataSource = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ShowPasien()
        {
            try
            {
                var kon = Koneksi_DB.GetOracleConnection();
                using(OracleCommand cmd = new OracleCommand
                    ("select * from tblpasien",kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        DgvPasien.DataSource = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string Ftime = "HH:mm:ss";
            string Fdate = "dd MMMM yyyy";
            LblTime.Text = (time.ToString(Ftime));
            LblDate.Text = (time.ToString(Fdate));
            
            //menampilkan jumlah pasien
            var kon = Koneksi_DB.GetOracleConnection();
            kon.Open();
            using (OracleCommand cmdd = new OracleCommand
                ("select count(*) from tblpasien", kon))
            {
                using (OracleDataReader reader = cmdd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pasien;
                        pasien = reader["COUNT(*)"].ToString();
                        pasienbtn.Text = "Pasien : " + pasien;
                    }

                }
            }

            using (OracleCommand cmdd = new OracleCommand
                ("select count(*) from tbldokter", kon))
            {
                using (OracleDataReader reader = cmdd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pasien;
                        pasien = reader["COUNT(*)"].ToString();
                        dokbtn.Text = "Dokter : " + pasien;
                    }
                }
            }

            using (OracleCommand cmdd = new OracleCommand
                ("select count(*) from tblobat", kon))
            {
                using (OracleDataReader reader = cmdd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pasien;
                        pasien = reader["COUNT(*)"].ToString();
                        obatbtn.Text = "Obat : " + pasien;
                    }
                }
            }

            using (OracleCommand cmdd = new OracleCommand
                ("select count(*) from tblpelayanan", kon))
            {
                using (OracleDataReader reader = cmdd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string pasien;
                        pasien = reader["COUNT(*)"].ToString();
                        pgbbtn.Text = "PGB : " + pasien;
                    }
                }
            }
            kon.Close();


        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }

     
    }
}
