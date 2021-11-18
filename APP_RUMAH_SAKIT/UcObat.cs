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
    public partial class UcObat : UserControl
    {
        public UcObat()
        {
            InitializeComponent();
        }

        public void clear()
        {
            TxtHarga.Clear();
            TxtJumlah.Clear();
            TxtKdObat.Clear();
            TxtKeterangan.Clear();
            TxtNamaObat.Clear();
            CmbJenisObat.Text = "";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try{
                string query = string.Format("insert into tblobat values('"+this.TxtKdObat.Text+"','"+this.TxtNamaObat.Text+"','"+this.CmbJenisObat.Text+"','"+this.TxtHarga.Text+"','"+this.TxtJumlah.Text+"','"+this.TxtKeterangan.Text+"')");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd=kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();;
                clear();
                MessageBox.Show("Data berhasil di tambah");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TxtKdObat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var kon = Koneksi_DB.GetOracleConnection();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tblobat where kodeobat='" + this.TxtKdObat.Text + "'",kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TxtHarga.Text = reader["harga"].ToString();
                            TxtJumlah.Text = reader["jumlah"].ToString();
                            TxtKeterangan.Text = reader["keterangan"].ToString();
                            TxtNamaObat.Text = reader["namaobat"].ToString();
                            CmbJenisObat.Text = reader["jenisobat"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update tblobat set namaobat='" + this.TxtNamaObat.Text + "',jenisobat='" + this.CmbJenisObat.Text + "',harga='" + this.TxtHarga.Text + "',jumlah='" + this.TxtJumlah.Text + "',keterangan='" + this.TxtKeterangan.Text + "' where kodeobat='"+this.TxtKdObat.Text+"'");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("data berhasil di ubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from tblobat where kodeobat='" + this.TxtKdObat.Text + "'");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("data berhasil di hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UcObat_Load(object sender, EventArgs e)
        {

        }
    }
}
