using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyek_besar_pbo_baihaqi_zidan.View;
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
                
                // ambil id_user
                int id_user = Convert.ToInt32(dt.Rows[0]["id_user"]);
                string username = dt.Rows[0]["username"].ToString();
                string password = dt.Rows[0]["password"].ToString();
                string role = dt.Rows[0]["role"].ToString();

                // 2. SIMPAN KE SESSION
                Proyek_besar_pbo_baihaqi_zidan.Model.Session.CurrentUser = new Proyek_besar_pbo_baihaqi_zidan.Model.UserModel
                {
                    IdUser = id_user,
                    Username = username,
                    Password = password,
                    Role = role
                };

                // ADMIN → ParentForm
                if (role == "Admin")
                {
                    role = dt.Rows[0]["role"].ToString();
                    ParentForm parent = new ParentForm(role);
                    parent.Show();
                    this.Hide();
                }
                // USER BIASA → LANGSUNG TOP UP
                else
                {
                    FormTopUpGame topup = new FormTopUpGame();
                    topup.Show();
                }
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

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
           btnLogin.BackColor = Color.DarkOrchid;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkSlateBlue;
        }
    }
}