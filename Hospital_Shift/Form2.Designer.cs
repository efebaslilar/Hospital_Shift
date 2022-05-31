
namespace Hospital_Shift
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxGosterilecekPersonel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(667, 264);
            this.listBox1.TabIndex = 0;
            // 
            // comboBoxGosterilecekPersonel
            // 
            this.comboBoxGosterilecekPersonel.FormattingEnabled = true;
            this.comboBoxGosterilecekPersonel.Items.AddRange(new object[] {
            "Cerrahi Doktor",
            "Asistan Doktor",
            "Hemsire"});
            this.comboBoxGosterilecekPersonel.Location = new System.Drawing.Point(106, 23);
            this.comboBoxGosterilecekPersonel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGosterilecekPersonel.Name = "comboBoxGosterilecekPersonel";
            this.comboBoxGosterilecekPersonel.Size = new System.Drawing.Size(180, 21);
            this.comboBoxGosterilecekPersonel.TabIndex = 3;
            this.comboBoxGosterilecekPersonel.Text = "Gösterilecek Personel Seç";
            this.comboBoxGosterilecekPersonel.SelectedIndexChanged += new System.EventHandler(this.comboBoxGosterilecekPersonel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seçili Olanın Nöbet Bilgisini Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxGosterilecekPersonel);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxGosterilecekPersonel;
        private System.Windows.Forms.Button button1;
    }
}