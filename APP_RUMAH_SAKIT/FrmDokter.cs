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
    public partial class FrmDokter : Form
    {
        public FrmDokter()
        {
            InitializeComponent();
        }

        public FrmDokter(string terima)
            : this()
        {
            LblKodeDokter.Text = terima;
        }

        private void ShowNama()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection
                    ("User ID= dbrs" + ";Password=dbrs" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select * from tbldokter where kodedokter='" +
                    LblKodeDokter.Text + "'", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BtnNamaDokter.Text = (reader["NAMA"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private readonly UcDiagnose _myUcDiagnose = new UcDiagnose { Dock = DockStyle.Fill };
        private readonly UcResep _myUcResep = new UcResep { Dock = DockStyle.Fill };
        private readonly UcPasienD _myUcPasienD = new UcPasienD { Dock = DockStyle.Fill };

        #region From Drag (Source Code Supaya Form bisa di pindahkan)
        private bool mouseDown;
        private Point lastLocation;

        private void FrmDokter_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmDokter_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FrmDokter_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void PctLogout_Click(object sender, EventArgs e)
        {
            DialogResult MyDialogResult = MessageBox.Show("Keluar dari menu DOKTER ?","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (MyDialogResult == DialogResult.Yes)
            {
                FrmLogin GoLogin = new FrmLogin();
                GoLogin.Show();
                this.Hide();
            }
        }

        private void FrmDokter_Load(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Data Pasien";
            BtnDataPasien_Click(sender, e);
            ShowNama();
        }

        private void BtnDataPasien_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Data Pasien";
            BtnDataPasien.ForeColor = Color.DeepSkyBlue;
            BtnDiagnose.ForeColor = Color.Black;
            BtnDataResep.ForeColor = Color.Black;
            //Source Code untuk memanggil User Control Pasien
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcPasienD))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcPasienD);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;
            //--------------------------------------------------
        }

        private void BtnDiagnose_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Diagnose";
            BtnDataPasien.ForeColor = Color.Black;
            BtnDiagnose.ForeColor = Color.DeepSkyBlue;
            BtnDataResep.ForeColor = Color.Black;
            //Source Code untuk memanggil User Control Diagnose
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcDiagnose))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcDiagnose);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;
            //--------------------------------------------------
        }

        private void BtnDataResep_Click(object sender, EventArgs e)
        {
            LblInfoMenu.Text = "Data Resep";
            BtnDataPasien.ForeColor = Color.Black;
            BtnDiagnose.ForeColor = Color.Black;
            BtnDataResep.ForeColor = Color.DeepSkyBlue;
            //Source Code untuk memanggil User Control Resep
            Cursor.Current = Cursors.WaitCursor;
            SuspendLayout();
            if (!PanelUsControl.Controls.Contains(_myUcResep))
            {
                PanelUsControl.Controls.Clear();
                PanelUsControl.Controls.Add(_myUcResep);
            }
            else
            {
                PanelUsControl.Controls.Clear();
            }
            ResumeLayout(false);
            Cursor.Current = Cursors.Default;
            //--------------------------------------------------
        }


    }
}
