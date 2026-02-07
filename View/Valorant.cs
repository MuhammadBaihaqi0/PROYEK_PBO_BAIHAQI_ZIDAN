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
    public partial class Valorant : Form
    {
        public Valorant()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SetErrorMessage(textBox2, "Riot ID tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox2, string.Empty);
            }
        }
    }
}
