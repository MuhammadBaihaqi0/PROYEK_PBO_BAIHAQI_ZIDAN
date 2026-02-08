using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyek_besar_pbo_baihaqi_zidan.Controller;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Proyek_besar_pbo_baihaqi_zidan.lib;


namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class FormUser : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_user;
        string roleUser;

        // constructor dengan role
        public FormUser(string role)
        {
            InitializeComponent();
            roleUser = role;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Tampil();

            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("User");
        }

        public void Tampil()
        {
            DataUser.DataSource = koneksi.ShowData(
        "SELECT id_user, username, password, role FROM users");

            DataUser.Columns[0].HeaderText = "ID";
            DataUser.Columns[1].HeaderText = "Username";
            DataUser.Columns[2].HeaderText = "Password";
            DataUser.Columns[3].HeaderText = "Role";
        }

        public void ResetForm()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            cbRole.SelectedIndex = -1;
            id_user = null;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            string sql = "INSERT INTO users (username, password, role) VALUES (@u,@p,@r)";
            koneksi.ExecuteQueryParam(sql,
                new MySqlParameter("@u", tbUsername.Text),
                new MySqlParameter("@p", tbPassword.Text),
                new MySqlParameter("@r", cbRole.Text)
            );

            ResetForm();
            Tampil();
        }

        private void DataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex < 0) return;

                id_user = DataUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbUsername.Text = DataUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPassword.Text = DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbRole.Text = DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_user == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            string sql =
                "UPDATE users SET username=@u, password=@p, role=@r WHERE id_user=@id";

            koneksi.ExecuteQueryParam(sql,
                new MySqlParameter("@u", tbUsername.Text),
                new MySqlParameter("@p", tbPassword.Text),
                new MySqlParameter("@r", cbRole.Text),
                new MySqlParameter("@id", id_user)
            );

            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (id_user == null) return;

            DialogResult d = MessageBox.Show(
                "Yakin hapus user ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (d == DialogResult.Yes)
            {
                koneksi.ExecuteQueryParam(
                    "DELETE FROM users WHERE id_user=@id",
                    new MySqlParameter("@id", id_user)
);
                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Tampil();
            ResetForm();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxCariData.Text.Trim();

            if (keyword == "")
            {
                Tampil();
                return;
            }

            string sql =
                "SELECT id_user, username, role FROM users " +
                "WHERE username LIKE @param OR role LIKE @param";

            DataUser.DataSource = koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@param", "%" + keyword + "%")
);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (DataUser.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diexport");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel File (*.xlsx)|*.xlsx";
            save.FileName = "Data_User.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Excel.Export(DataUser, save.FileName);
                MessageBox.Show("Data berhasil diexport ke Excel");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
