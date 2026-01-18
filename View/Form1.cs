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
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource =
        koneksi.ShowData("SELECT * FROM users");
        }
    }
}
