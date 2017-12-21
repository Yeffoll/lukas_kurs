using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form1 : Form
    {

        int raz = 0;
        int dva = 0;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

      public int slojenie(int raz, int dva)
        {

            return raz+dva;
        }

        public int ymnojenie(int raz, int dva)
        {

            return raz * dva;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Оба поля долны быть не пустые!");
                return;
            }

            raz = Convert.ToUInt16(textBox1.Text);
            dva = Convert.ToUInt16(textBox2.Text);

            if (radioButton1.Checked == true)
            {
                textBox3.Text = slojenie(raz, dva).ToString();
            }

            if (radioButton2.Checked == true)
            {
                textBox3.Text = ymnojenie(raz, dva).ToString();
            }

        }
    }
}
