using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatrice_winform_con_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n1) && int.TryParse(textBox2.Text, out int n2)){
                listBox1.Items.Add($"{n1 + n2}");
            }
            else
            {
                label.Text = "Errore: inserire solo numeri";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n1) && int.TryParse(textBox2.Text, out int n2))
            {
                listBox1.Items.Add($"{n1 - n2}");
            }
            else
            {
                label.Text = "Errore: inserire solo numeri";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n1) && int.TryParse(textBox2.Text, out int n2))
            {
                listBox1.Items.Add($"{n1 * n2}");
            }
            else
            {
                label.Text = "Errore: inserire solo numeri";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n1) && int.TryParse(textBox2.Text, out int n2))
            {
                listBox1.Items.Add($"{n1 / n2}");
            }
            else
            {
                label.Text = "Errore: inserire solo numeri";
            }
        }
    }
}
