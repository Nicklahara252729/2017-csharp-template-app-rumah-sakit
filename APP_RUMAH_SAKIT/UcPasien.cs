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
    public partial class UcPasien : UserControl
    {
        public UcPasien()
        {
            InitializeComponent();
        }

        private void UcPasien_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            TxtKdPasien.Clear();
            TxtNamaPasien.Clear();
            TxtTglLahir.Clear();
            TxtAlamat.Clear();
            TxtNoHp.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into tblpasien values('" + this.TxtKdPasien.Text + "','" + this.TxtNamaPasien.Text + "','" + this.TxtTglLahir.Text + "','" + this.TxtAlamat.Text + "','" + this.TxtNoHp.Text + "')");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("Data berhasil di tambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtKdPasien_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var kon = Koneksi_DB.GetOracleConnection();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tblpasien where kodepasien ='" + this.TxtKdPasien.Text + "'", kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TxtNamaPasien.Text = reader["NAMAPASIEN"].ToString();
                            TxtAlamat.Text = reader["ALAMAT"].ToString();
                            TxtNoHp.Text = reader["HP"].ToString();
                            TxtTglLahir.Text = reader["TGLLAHIR"].ToString();
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
            try{
                string query = string.Format("update tblpasien set namapasien='"+this.TxtNamaPasien.Text+"',tgllahir='"+this.TxtTglLahir.Text+"',alamat='"+this.TxtAlamat.Text+"',hp='"+this.TxtNoHp.Text+"'");
                var kon = Koneksi_DB.GetOracleConnection();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                clear();
                MessageBox.Show("Data berhasil di update");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pesan = MessageBox.Show("Data Akan di Hapus", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pesan == DialogResult.Yes)
                {
                    string query = string.Format("delete from tblpasien where kodepasien='" + this.TxtKdPasien.Text + "'");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
