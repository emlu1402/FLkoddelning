using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlKoddelning
{
    public partial class Form1 : Form
    {
        public void EriksMetod()
        {
            // en ny metod...
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hej det här kommer från Erik. Och det här från mig. Nu har texten utökats ytterligare");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Det här finns bara i den nya branchen och numera i master också");
            MessageBox.Show("Mbox1");
            MessageBox.Show("Mbox2");
            MessageBox.Show("Mbox3");
            MessageBox.Show("Mbox5");
            MessageBox.Show("Mbox6");
            MessageBox.Show("Mbox7");

        }
    }
}
