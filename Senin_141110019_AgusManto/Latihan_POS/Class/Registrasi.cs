using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class Registrasi
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=latihan_pos; Uid=root; pwd=''";
        MySqlCommand cmd;

        private bool Angka(String angka)
        {

            for (int i = 0; i < angka.Length; i++)
                if (!char.IsNumber(angka[i]))
                    return false;
            return true;
        }

        public bool IsText(String text)
        {
            for (int i = 0; i < text.Length; i++)

                if (char.IsNumber(text[i]))
                    return false;
            return true;

        }

        private bool cekKode(String column, String value)
        {
            bool hasil = false;
            if (column == "kodebarang")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblbarang WHERE " + column + " = '" + value + "';";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Database Error");
                }
            }
            else if (column == "kodeSupplier")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblsupplier WHERE " + column + " = '" + value + "';";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Database Error");
                }
            }
            else if (column == "noHPCustomer")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblcustomer WHERE " + column + " = '" + value + "';";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Database Error");
                }
            }
            else if (column == "noHPSupplier")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblsupplier WHERE " + column + " = '" + value + "';";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Database Error");
                }
            }
            return hasil;
        }

        public void tambahBarang(string kode, string nama, string jumlah, string hargaAwal, string hargaJual)
        {
            conn = new MySqlConnection(connString);

            if (cekKode("kodebarang", kode))
            {
                MessageBox.Show("Kode Telah Digunakan");
                return;
            }
            if (nama == "")
            {
                MessageBox.Show("Nama Tidak boleh kosong");
                return;
            }
            if (jumlah == "" || !Angka(jumlah))
            {
                MessageBox.Show("Jumlah diisi dengan angka");
                return;
            }
            if (hargaAwal == "" || !Angka(hargaAwal))
            {
                MessageBox.Show("Harga diisi dengan angka");
                return;
            }
            if (hargaJual == "" || !Angka(hargaJual))
            {
                MessageBox.Show("Harga diisi dengan angka");
                return;
            }
            try
            {
                conn.Open();
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                DateTime update = DateTime.Now;
                String waktuUpdate = update.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();

                string insert = "INSERT INTO tblbarang (kodeBarang,nama,jumlahawal,hargahpp,hargajual,createDate,updateDate)";
                insert += " VALUES (@kode,@nama,@jumlah,@hargahpp,@hargajual,@createDate,@updatedate)";

                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@hargahpp", hargaAwal);
                cmd.Parameters.AddWithValue("@hargajual", hargaJual);
                cmd.Parameters.AddWithValue("@createDate", waktuNow);
                cmd.Parameters.AddWithValue("@updatedate", waktuUpdate);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Barang Sukses");
            }
            catch
            {
                MessageBox.Show("Database Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void tambahCustomer(string nama, string alamat, string nohp)
        {
            conn = new MySqlConnection(connString);
            Status status = new Status();
            bool hsl = status.cekKode(nama, "Customer");
            
            if (nama == "")
            {
                MessageBox.Show("Nama Tidak boleh kosong");
                return;
            }
            if (alamat == "")
            {
                MessageBox.Show("Alamat Tidak boleh kosong");
                return;
            }
            if (!Angka(nohp))
            {
                MessageBox.Show("Nomor HP Hanya boleh diisi dengan angka");
                return;
            }
            if (cekKode("noHPCustomer", nohp))
            {
                MessageBox.Show("Nomor telah digunakan");
                return;
            }
            if (hsl)
            {
                MessageBox.Show("Kode sudah dipakai");
            }
            else
            {
                try
                {
                    conn.Open();
                    DateTime sekarang = DateTime.Now;
                    String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                    DateTime update = DateTime.Now;
                    String waktuUpdate = update.ToString("yyyy/MM/dd HH:mm:ss");
                    MySqlCommand cmd = conn.CreateCommand();

                    string insert = "INSERT INTO tblcustomer (nama_customer,alamat_customer,noHPCustomer,createdate,updatedate)";
                    insert += " VALUES (@nama,@alamat,@noHP,@waktuNow,@waktuUpdate)";

                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@noHP", nohp);
                    cmd.Parameters.AddWithValue("@waktuNow", waktuNow);
                    cmd.Parameters.AddWithValue("@waktuUpdate", waktuUpdate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tambah Customer Sukses");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void tambahSupplier(string kode, string nama, string alamat, string noHP, string kota)
        {
            conn = new MySqlConnection(connString);
            if (cekKode("kodeSupplier", kode))
            {
                MessageBox.Show("Kode Telah Digunakan");
                return;
            }
            if (nama == "")
            {
                MessageBox.Show("Nama Tidak boleh kosong");
                return;
            }
            if (alamat.ToLower() == "")
            {
                MessageBox.Show("Alamat tidak boleh kosong");
                return;
            }
            if (!IsText(kota.ToLower()))
            {
                MessageBox.Show("Isi nama kota");
                return;
            }
            if (!Angka(noHP))
            {
                MessageBox.Show("Nomor HP tidak sesuai");
                return;
            }
            if (cekKode("noHPSupplier", noHP))
            {
                MessageBox.Show("Nomor HP sudah dipakai");
                return;
            }
            try
            {
                conn.Open();
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                DateTime update = DateTime.Now;
                String waktuUpdate = update.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();

                string insert = "INSERT INTO tblsupplier (kodeSupplier,nama,alamat,kota,noHPSupplier,createDate,updateDate)";
                insert += " VALUES (@kode,@nama,@alamat,@kota,@noHP,@createDate,@updatedate)";

                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@kota", kota);
                cmd.Parameters.AddWithValue("@noHP", noHP);
                cmd.Parameters.AddWithValue("@createDate", waktuNow);
                cmd.Parameters.AddWithValue("@updatedate", waktuUpdate);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Supplier Sukses");
            }
            catch
            {
                MessageBox.Show("Database Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
