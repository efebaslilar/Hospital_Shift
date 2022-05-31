using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Shift.Entities;
using Hospital_Shift.Properties;
using Hospital_Shift.Interface;


namespace Hospital_Shift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
               
        }
        ////property mi ? eğişken
        //int a=5; //field
        public int aa { get; set; } = 5; //property

        public static List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public static List<AsistanDoktor> AsistanDoktorlar { get; set; } = new List<AsistanDoktor>();
        public static List<CerrahiDoktor> CerrahiDoktorlar { get; set; } = new List<CerrahiDoktor>();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            string[] cnsyet = Enum.GetNames(typeof(Cinsiyet));
            comboBox1.Items.AddRange(cnsyet);
            
        }
        
        private void comboBoxPersonelSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPersonelSec.SelectedIndex==0)
            {
                groupBox1.Enabled = true;
                label6.Enabled = false;
                txtboxnobetsaat.Enabled = false;
                RadiobtnNobetTutacakMi.Checked = false;
                RadiobtnNobetTutacakMi.Enabled = false;
            }
            if (comboBoxPersonelSec.SelectedIndex==1)
            {
                label6.Enabled = true;
                txtboxnobetsaat.Enabled = true;
                groupBox1.Enabled = true;
                RadiobtnNobetTutacakMi.Enabled = true;
            }
            if (comboBoxPersonelSec.SelectedIndex==2)
            {
                groupBox1.Enabled = true;
                label6.Enabled = true;
                txtboxnobetsaat.Enabled = true;
                RadiobtnNobetTutacakMi.Checked=true;
                RadiobtnNobetTutacakMi.Enabled = false;
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonelSec.SelectedIndex==0)
            {
                CerrahiDoktor cdoktor = new CerrahiDoktor();
                cdoktor.isim = txtboxisim.Text;
                cdoktor.telefon = txtboxtel.Text;
                cdoktor.tcno = txtboxtc.Text;
                cdoktor.maas = Convert.ToDouble(txtboxmaas.Text);
                cdoktor.Cinsiyet = (Cinsiyet)comboBox1.SelectedIndex;
                CerrahiDoktorlar.Add(cdoktor);
                temizle();
                comboBoxPersonelSec.SelectedItem = -1;
                MessageBox.Show($"{comboBoxPersonelSec.SelectedItem} başarıyla kaydoldu");
            }
            if (comboBoxPersonelSec.SelectedIndex == 1)
            {
                AsistanDoktor asdoktor = new AsistanDoktor();
                asdoktor.isim = txtboxisim.Text;
                asdoktor.telefon = txtboxtel.Text;
                asdoktor.tcno = txtboxtc.Text;
                asdoktor.maas = Convert.ToDouble(txtboxmaas.Text);
                asdoktor.Cinsiyet = (Cinsiyet)comboBox1.SelectedIndex;
                asdoktor.nobettutacakmı = RadiobtnNobetTutacakMi.Checked;
                asdoktor.nobetsaati = Convert.ToInt32(txtboxnobetsaat.Text);
                temizle();
                

                MessageBox.Show($"{comboBoxPersonelSec.SelectedItem} başarıyla kaydoldu");
            }
            if (comboBoxPersonelSec.SelectedIndex == 2)
            {
                Hemsire hmsr = new Hemsire();
                hmsr.isim = txtboxisim.Text;
                hmsr.telefon = txtboxtel.Text;
                hmsr.tcno = txtboxtc.Text;
                hmsr.maas = Convert.ToDouble(txtboxmaas.Text);
                hmsr.nobetsaati = Convert.ToInt32(txtboxnobetsaat.Text);
                Hemsireler.Add(hmsr);
                temizle();

                MessageBox.Show($"{comboBoxPersonelSec.SelectedItem} başarıyla kaydoldu");
            }
            
        }
        void temizle()
        {
            foreach (var item in this.Controls)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
