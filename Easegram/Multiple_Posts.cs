using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication33
{
    public partial class Multiple_Posts : Form
    {
        public Multiple_Posts()
        {
            InitializeComponent();
        }

        private void Multiple_Posts_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false; this.MaximizeBox = false;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                button2.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.use_mpl = true;
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength >= 19 || richTextBox1.TextLength >= richTextBox1.MaxLength)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
