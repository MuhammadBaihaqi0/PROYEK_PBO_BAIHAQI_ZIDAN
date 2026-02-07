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
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            tbConfirm.UseSystemPasswordChar = true;
            Cekpass.Checked = false;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validasi textbox kosong
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbConfirm.Text == "")
            {
                MessageBox.Show(
                    "Username dan Password wajib diisi",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // validasi konfirmasi password
            if (tbPassword.Text != tbConfirm.Text)
            {
                MessageBox.Show(
                    "Password dan Konfirmasi Password tidak sama, Mohon Sesuaikan",
                    "Registrasi Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                tbConfirm.Focus();
                return;
            }

            // cek user sudah ada atau belum
            string CekUser = "SELECT * FROM users WHERE username='" + tbUsername.Text + "'";
            DataTable dt = koneksi.ShowData(CekUser);

            // jika data ditemukan tetapi sudah ada akun
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Username sudah terdaftar, silakan gunakan username lain",
                    "Registrasi Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // insert data user baru
            string insert = "INSERT INTO users (username, password, role) VALUES (" +
                    "'" + tbUsername.Text + "', " +
                    "'" + tbPassword.Text + "', " +
                    "'user')";

            bool result = koneksi.ExecuteQuery(insert);

            if (result)
            {
                MessageBox.Show(
                    "Registrasi berhasil, silakan login",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // kembali ke login
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Registrasi gagal, silakan coba lagi",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cekpass_CheckedChanged(object sender, EventArgs e)
        {
            bool hideChar = !Cekpass.Checked;

            tbPassword.UseSystemPasswordChar = hideChar;
            tbConfirm.UseSystemPasswordChar = hideChar;
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.DarkOrchid;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.DarkSlateBlue;
        }
    }
}
