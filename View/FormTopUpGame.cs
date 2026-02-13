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
        public FormTopUpGame()
        {
            InitializeComponent();
            
            // Properties moved to caller (ParentForm) to allow standalone usage
            // this.TopLevel = false;
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.Dock = DockStyle.Fill;

            button1.MouseEnter += AllButtons_MouseEnter;
            button1.MouseLeave += AllButtons_MouseLeave;
            button2.MouseEnter += AllButtons_MouseEnter;
            button2.MouseLeave += AllButtons_MouseLeave;
            button3.MouseEnter += AllButtons_MouseEnter;
            button3.MouseLeave += AllButtons_MouseLeave;
            button4.MouseEnter += AllButtons_MouseEnter;
            button4.MouseLeave += AllButtons_MouseLeave;
            button5.MouseEnter += AllButtons_MouseEnter;
            button5.MouseLeave += AllButtons_MouseLeave;
            button6.MouseEnter += AllButtons_MouseEnter;
            button6.MouseLeave += AllButtons_MouseLeave;
        }

        public FormTopUpGame(string v) : this()
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormdiamondML diamondML = new FormdiamondML();
            diamondML.Show();
        }

        private void AllButtons_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkOrchid;
        }

        private void AllButtons_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSlateBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PUBG pubg = new PUBG();
            pubg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormdiamondFreeFire diamondFF = new FormdiamondFreeFire();
            diamondFF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PB pb  = new PB();
            pb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Valorant valorant = new Valorant();
            valorant.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Roblox roblox = new Roblox();
            roblox.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormdiamondML diamondML = new FormdiamondML();
            diamondML.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PUBG pubg = new PUBG();
            pubg.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormdiamondFreeFire diamondFF = new FormdiamondFreeFire();
            diamondFF.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PB pb = new PB();
            pb.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Valorant valorant = new Valorant();
            valorant.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Roblox roblox = new Roblox();
            roblox.Show();
        }

        private void FormTopUpGame_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}