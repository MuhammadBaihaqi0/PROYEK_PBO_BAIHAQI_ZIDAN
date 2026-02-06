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
    public partial class FormTopUpGame : Form
    {

        public FormTopUpGame(string v)
        {
            InitializeComponent();

            // SET SEBAGAI CHILD MDI
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ================== OPEN ITEM ==================
        void OpenItem(int idGame, string namaGame)
        {
            FormItem item = new FormItem(idGame, namaGame);
            item.MdiParent = this.MdiParent;
            item.Show();
            this.Close();
        }

        // EVENT CLICK

        // OPTIONAL: supaya panel ikut bisa diklik
       
        private void FlowGames_Paint(object sender, PaintEventArgs e)
        {
            // Kosongkan saja, tidak apa-apa
        }
        private void FormTopUpGame_Load(object sender, EventArgs e)
        {
          
        }

        private void pbML_Click_1(object sender, EventArgs e)
        {
            OpenItem(1, "Mobile Legends");
        }

        private void pbFF_Click_1(object sender, EventArgs e)
        {
            OpenItem(1, "Mobile Legends");
        }

        private void pbPUBG_Click_1(object sender, EventArgs e)
        {
            OpenItem(2, "Free Fire");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenItem(1, "Mobile Legends");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrchid;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenItem(2, "Free Fire");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenItem(4, "Point Blank");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenItem(5, "Valorant");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenItem(3, "PUBG Mobile");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenItem(6, "Roblox");
        }
    }
}