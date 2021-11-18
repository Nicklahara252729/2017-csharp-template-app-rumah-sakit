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
    public partial class UcDokter : UserControl
    {
        public UcDokter()
        {
            InitializeComponent();
        }

        public void clear()
        {
            TxtAlamat.Clear();
            TxtKdDokter.Clear();
            TxtNamaDokter.Clear();
            TxtNoHp.Clear();
            CmbJKelamin.Text="";
            CmbSpesialis.Text = "";
        }

        private void BtnPengobatan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into tbldokter values ('" + this.TxtKdDokter.Text + "','" + this.TxtNamaDokter.Text + "','" + this.CmbJKelamin.Text + "','" + this.TxtAlamat.Text + "','" + this.TxtNoHp.Text + "','" + this.CmbSpesialis.Text + "')");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                cmd.Clone();
                clear();
                MessageBox.Show("Data berhasil di tambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update tbldokter set namadokter='" + this.TxtNamaDokter.Text + "', jeniskelamin='" + this.CmbJKelamin.Text + "', alamat='" + this.TxtAlamat.Text + "', hp ='" + this.TxtNoHp.Text + "', spesialis='" + this.CmbSpesialis.Text + "' where kodedokter='"+this.TxtKdDokter.Text+"'");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("Data berhasil di ubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtKdDokter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var kon = Koneksi_DB.GetOracleConnection();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tbldokter where kodedokter='" + this.TxtKdDokter.Text + "'", kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TxtAlamat.Text = reader["alamat"].ToString();
                            TxtNamaDokter.Text = reader["namadokter"].ToString();
                            TxtNoHp.Text = reader["hp"].ToString();
                            CmbJKelamin.Text = reader["jeniskelamin"].ToString();
                            CmbSpesialis.Text = reader["spesialis"].ToString();
                        }
                    }
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from tbldokter where kodedokter='" + this.TxtKdDokter.Text + "'");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("Data berhasil di hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
