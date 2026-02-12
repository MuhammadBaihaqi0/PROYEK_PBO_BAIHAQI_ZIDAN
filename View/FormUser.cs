using System;
using System.Data;
using System.Windows.Forms;
using Proyek_besar_pbo_baihaqi_zidan.Controller;
using Proyek_besar_pbo_baihaqi_zidan.Model;
using Proyek_besar_pbo_baihaqi_zidan.lib;

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class FormUser : Form
    {
        UserController userController = new UserController();
        int id_user = -1;
        string roleUser;

        public FormUser(string role)
        {
            InitializeComponent();
            roleUser = role;
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
            DataUser.DataSource = userController.GetAll();

            DataUser.Columns[0].HeaderText = "ID";
            DataUser.Columns[1].HeaderText = "Username";
            DataUser.Columns[2].HeaderText = "Password";
            DataUser.Columns[3].HeaderText = "Role";

            DataUser.Columns[2].Visible = false;
        }

        public void ResetForm()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            cbRole.SelectedIndex = -1;
            id_user = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            UserModel user = new UserModel
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Role = cbRole.Text
            };

            userController.Insert(user);
            ResetForm();
            Tampil();
        }

        private void DataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id_user = Convert.ToInt32(DataUser.Rows[e.RowIndex].Cells[0].Value);
            tbUsername.Text = DataUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPassword.Text = DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbRole.Text = DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_user == -1)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            UserModel user = new UserModel
            {
                IdUser = id_user,
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Role = cbRole.Text
            };

            userController.Update(user);
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (id_user == -1) return;

            DialogResult d = MessageBox.Show(
                "Yakin hapus user ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (d == DialogResult.Yes)
            {
                userController.Delete(id_user);
                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxCariData.Text.Trim();

            if (keyword == "")
            {
                Tampil();
                return;
            }

            DataUser.DataSource = userController.Search(keyword);
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (DataUser.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diexport");
                return;
            }

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Excel File (*.xlsx)|*.xlsx",
                FileName = "Data_User.xlsx"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                Excel.Export(DataUser, save.FileName);
                MessageBox.Show("Data berhasil diexport ke Excel");
            }
        }
    }
}
