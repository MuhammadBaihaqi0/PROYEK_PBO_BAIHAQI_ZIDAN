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
    public partial class ParentForm : Form
    {
        string roleUser;

        public ParentForm(string role)
        {
            InitializeComponent();
            roleUser = role;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            if (roleUser == "User")
            {
                menuUsers.Visible = false;
            }
        }

        private void menuUsers_Click(object sender, EventArgs e)
        {
            // 🔒 CEK ROLE DI SINI (AMAN)
            if (roleUser != "Admin")
            {
                MessageBox.Show(
                    "Anda tidak memiliki hak akses ke menu Data Users",
                    "Akses Ditolak",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // tutup child lain
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // buka FormUsers (HANYA ADMIN)
            FormUser users = new FormUser(roleUser);
            users.MdiParent = this;
            users.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();

            FormTopUpGame topup = new FormTopUpGame();
            topup.MdiParent = this;
            topup.FormBorderStyle = FormBorderStyle.None; // Match previous child behavior
            topup.Dock = DockStyle.Fill;
            topup.Show();
        }


    }
}