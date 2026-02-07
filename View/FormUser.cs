using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyek_besar_pbo_baihaqi_zidan.Controller;

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class FormUser : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_user;
        string roleUser;

        public FormUser()
        {
            InitializeComponent();
            roleUser = roleUser;

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("User");

            TampilData();
        }

        void TampilData()
        {
            DataUser.DataSource =
                koneksi.ShowData("SELECT * FROM users");
        }

        void ResetForm()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            cbRole.SelectedIndex = -1;
            id_user = null;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (
               tbUsername.Text == "" ||
               tbPassword.Text == "" ||
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
                "'" + cbRole.Text + "'" +
                ")";

            koneksi.ShowData(query);
            MessageBox.Show("Data user berhasil ditambahkan");

            TampilData();
            ResetForm();
        }

        private void DataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataUser.Rows[e.RowIndex];
                id_user = row.Cells["id_user"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();
                tbPassword.Text = row.Cells["password"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();
            }
        }

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
                "role='" + cbRole.Text + "' " +
                "WHERE id_user=" + id_user;

            koneksi.ShowData(query);
            MessageBox.Show("Data user berhasil diubah");

            TampilData();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (id_user == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            if (MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.ShowData(
                    "DELETE FROM users WHERE id_user=" + id_user
                );

                MessageBox.Show("Data user berhasil dihapus");
                TampilData();
                ResetForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            ResetForm();
        }
    }
}
