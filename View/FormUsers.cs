using Proyek_besar_pbo_baihaqi_zidan.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class FormUsers : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_user; // simpan id saat klik tabel

        public FormUsers()
        {
            InitializeComponent();

            // SET SEBAGAI CHILD FORM (MDI)
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ================= LOAD FORM =================
        private void FormUsers_Load(object sender, EventArgs e)
        {
            // isi combo role
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("User");

            TampilData();
        }

        // ================= TAMPIL DATA =================
        void TampilData()
        {
            dataGridView1.DataSource =
                koneksi.ShowData("SELECT * FROM users");
        }

        // ================= RESET FORM =================
        void ResetForm()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbSaldo.Clear();
            cbRole.SelectedIndex = -1;
            id_user = null;
        }

        // ================= SIMPAN =================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (
                tbUsername.Text == "" ||
                tbPassword.Text == "" ||
                tbSaldo.Text == "" ||
                cbRole.Text == ""
            )
            {
                MessageBox.Show("Semua field wajib diisi");
                return;
            }

            string query =
                "INSERT INTO users (username, password, saldo, role) VALUES (" +
                "'" + tbUsername.Text + "', " +
                "'" + tbPassword.Text + "', " +
                tbSaldo.Text + ", " +
                "'" + cbRole.Text + "'" +
                ")";

            koneksi.ShowData(query);

            MessageBox.Show("Data user berhasil ditambahkan");

            TampilData();
            ResetForm();
        }

        // ================= KLIK TABEL =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id_user = row.Cells["id_user"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();
                tbPassword.Text = row.Cells["password"].Value.ToString();
                tbSaldo.Text = row.Cells["saldo"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();
            }
        }

        // ================= UBAH =================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_user == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            string query =
                "UPDATE users SET " +
                "username='" + tbUsername.Text + "', " +
                "password='" + tbPassword.Text + "', " +
                "saldo=" + tbSaldo.Text + ", " +
                "role='" + cbRole.Text + "' " +
                "WHERE id_user=" + id_user;

            koneksi.ShowData(query);

            MessageBox.Show("Data user berhasil diubah");

            TampilData();
            ResetForm();
        }

        // ================= HAPUS =================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (id_user == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            DialogResult dialog = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.Yes)
            {
                string query =
                    "DELETE FROM users WHERE id_user=" + id_user;

                koneksi.ShowData(query);

                MessageBox.Show("Data user berhasil dihapus");

                TampilData();
                ResetForm();
            }
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            ResetForm();
        }
    }
}