using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("1-ci kurs");
            comboBox1.Items.Add("2-ci kurs");
            comboBox1.Items.Add("3-cü kurs");
            comboBox1.Items.Add("4-cü kurs");

            comboBox1.SelectedIndex = 0;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Siyahı.SelectedIndex == -1)
            {
                MessageBox.Show("Tələbə seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Tələbəni silmək istəyirsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo
            );

            if (cavab == DialogResult.Yes)
            {
                Siyahı.Items.RemoveAt(Siyahı.SelectedIndex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ad boş ola bilməz!");
                return;
            }

            string cins;

            if (radioButton1.Checked)
            {
                cins = "Kişi";
            }
            else
            {
                cins = "Qadın";
            }

            string telebe = textBox1.Text
                + " | Yaş: " + numericUpDown1.Value + " | Kurs: " + comboBox1.Text + " | Cins: " + cins;
            Siyahı.Items.Add(telebe);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Siyahı.SelectedIndex != -1)
            {
                label1.Text = Siyahı.SelectedItem.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
