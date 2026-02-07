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


        private void button1_Click(object sender, EventArgs e)
        {
            FormdiamondML diamondML = new FormdiamondML();
            diamondML.Show();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrchid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PUBG pubg = new PUBG();
            pubg.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormdiamondFreeFire diamondFF = new FormdiamondFreeFire();
            diamondFF.Show();
            this.Close();
        }
    }
}