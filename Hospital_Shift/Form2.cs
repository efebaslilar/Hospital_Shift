using Hospital_Shift.Entities;
using Hospital_Shift.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Shift
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBoxGosterilecekPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGosterilecekPersonel.SelectedIndex==0)
            {
                listBox1.DataSource = Form1.CerrahiDoktorlar;
            }
            if (comboBoxGosterilecekPersonel.SelectedIndex == 1)
            {
                listBox1.DataSource = Form1.AsistanDoktorlar;
            }
            if (comboBoxGosterilecekPersonel.SelectedIndex == 2)
            {
                listBox1.DataSource = Form1.Hemsireler;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxGosterilecekPersonel.SelectedIndex==0)
            {
                MessageBox.Show("Cerrahi Doktorlar Nöbet Tutmaz");
            }
            if (comboBoxGosterilecekPersonel.SelectedIndex == 1)
            {
                AsistanDoktor asdoktor = (AsistanDoktor)listBox1.SelectedItem;
                asdoktor.nobettut();
            }
            if (comboBoxGosterilecekPersonel.SelectedIndex == 2)
            {
                Hemsire hmsr = (Hemsire)listBox1.SelectedItem;
                hmsr.nobettut();

                

            }
        }
    }
}
