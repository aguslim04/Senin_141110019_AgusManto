using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.Class;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class FormListBarang : Form
    {
        List list = new List();
        public FormListBarang()
        {
            InitializeComponent();
            list.fillTable(dgvBarang);
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refresh()
        {
            list.fillTable(dgvBarang);
        }

        private void FormListBarang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvBarang.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string barang = dgvBarang.SelectedCells[1].Value.ToString();
                    Delete delete = new Delete();
                    delete.hapusBarang(barang);
                    refresh();
                }
                else
                {
                    refresh();
                }

            }
            else
            {
                MessageBox.Show("Nothing To Delete");
            }
        }
    }
}
