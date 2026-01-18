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
    public partial class Login : Form
    {
        // panggil koneksi database
        Koneksi koneksi = new Koneksi();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            Cekpass.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // validasi textbox kosong
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show(
                    "Username dan Password wajib diisi",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // query cek user
            string query = "SELECT * FROM users " +
                           "WHERE username='" + tbUsername.Text +
                           "' AND password='" + tbPassword.Text + "'";

            DataTable dt = koneksi.ShowData(query);

            // jika data ditemukan
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Login berhasil",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // buka parent form
                string role = dt.Rows[0]["role"].ToString();
                ParentForm parent = new ParentForm(role);
                parent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username atau Password salah",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !Cekpass.Checked;
        }
    }
}