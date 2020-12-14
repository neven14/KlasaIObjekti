using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasaOBjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Klasa osoba = new Klasa(textBox1.Text, Convert.ToInt32(textBox2));
              richTextBox1.Text = osoba.ToString();
            }
            catch (Exception greska)
            {
                MessageBox.Show("Greska", greska.Message);
            }
        }
    }
}
