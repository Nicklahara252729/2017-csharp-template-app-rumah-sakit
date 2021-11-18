using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace APP_RUMAH_SAKIT
{
    public partial class UcPengobatan : UserControl
    {
        public UcPengobatan()
        {
            InitializeComponent();
        }

        private void UcPengobatan_Load(object sender, EventArgs e)
        {
            kodepasien();
            dokter();
        }

        public void kodepasien()
        {
            var kon = Koneksi_DB.GetOracleConnection();
            using (OracleCommand cmd = new OracleCommand
                ("select * from tblpasien", kon))
            {
                kon.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CmbKdPasien.Items.Add(reader["kodepasien"].ToString() + " - " + reader["namapasien"].ToString());
                    }
                }
            }
        }

        public void dokter()
        {
            var kon = Koneksi_DB.GetOracleConnection();
            using(OracleCommand cmd = new OracleCommand
                ("select * from tbldokter", kon))
            {
                kon.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CmbNamaDokter.Items.Add(reader["kodedokter"].ToString() + " - " + reader["namadokter"].ToString());
                    }
                }
            }
        }

        private void DgvPengobatan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            TxtKdPelayanan.Clear();
            CmbKdPasien.Text="";
            TxtKeluhan.Clear();
            CmbNamaDokter.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string text1 = "", CmbPasien = "";
            text1 = CmbKdPasien.Text;
            string[] arr1 = text1.Split('*');
            CmbPasien = arr1[0].Trim();

            string text2 = "", CmbDokter = "";
            text2 = CmbNamaDokter.Text;
            string[] arr2 = text2.Split('*');
            CmbDokter = arr2[0].Trim();

            try
            {
                string query = string.Format("insert into tblpelayanan values('" + this.TxtKdPelayanan.Text + "','" + this.LblDate.Text + "','" + this.LblTime.Text + "','" + CmbDokter + "','" + CmbPasien + "','" + this.TxtKeluhan.Text + "')");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose(); ;
                clear();
                MessageBox.Show("Data berhasil di tambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblDate_Click(object sender, EventArgs e)
        {
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime waktu = DateTime.Now;
            string Ftime = "HH:mm:ss";
            string Fdate = "dd MMMM yyyy";
            LblDate.Text = (waktu.ToString(Fdate));
            LblTime.Text = (waktu.ToString(Ftime));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
