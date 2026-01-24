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
            pbML.Image = Properties.Resources.ml;
            pbFF.Image = Properties.Resources.ff;
            pbPUBG.Image = Properties.Resources.pubg;
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
    }
}