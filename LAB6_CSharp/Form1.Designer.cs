namespace LAB6_CSharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.numericUpDownPUP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBrojPaketa = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUProdaji = new System.Windows.Forms.RadioButton();
            this.radioButtonUSkladistu = new System.Windows.Forms.RadioButton();
            this.radioButtonNarucen = new System.Windows.Forms.RadioButton();
            this.checkBoxHitno = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPaketa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proizvoda u paketu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj paketa:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(164, 37);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaziv.TabIndex = 3;
            // 
            // numericUpDownPUP
            // 
            this.numericUpDownPUP.Location = new System.Drawing.Point(164, 70);
            this.numericUpDownPUP.Name = "numericUpDownPUP";
            this.numericUpDownPUP.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPUP.TabIndex = 7;
            // 
            // numericUpDownBrojPaketa
            // 
            this.numericUpDownBrojPaketa.Location = new System.Drawing.Point(164, 101);
            this.numericUpDownBrojPaketa.Name = "numericUpDownBrojPaketa";
            this.numericUpDownBrojPaketa.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBrojPaketa.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUProdaji);
            this.groupBox1.Controls.Add(this.radioButtonUSkladistu);
            this.groupBox1.Controls.Add(this.radioButtonNarucen);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status proizvoda";
            // 
            // radioButtonUProdaji
            // 
            this.radioButtonUProdaji.AutoSize = true;
            this.radioButtonUProdaji.Location = new System.Drawing.Point(269, 19);
            this.radioButtonUProdaji.Name = "radioButtonUProdaji";
            this.radioButtonUProdaji.Size = new System.Drawing.Size(67, 17);
            this.radioButtonUProdaji.TabIndex = 2;
            this.radioButtonUProdaji.TabStop = true;
            this.radioButtonUProdaji.Text = "U prodaji";
            this.radioButtonUProdaji.UseVisualStyleBackColor = true;
            this.radioButtonUProdaji.CheckedChanged += new System.EventHandler(this.radioButtonNarucen_CheckedChanged);
            // 
            // radioButtonUSkladistu
            // 
            this.radioButtonUSkladistu.AutoSize = true;
            this.radioButtonUSkladistu.Location = new System.Drawing.Point(137, 19);
            this.radioButtonUSkladistu.Name = "radioButtonUSkladistu";
            this.radioButtonUSkladistu.Size = new System.Drawing.Size(77, 17);
            this.radioButtonUSkladistu.TabIndex = 1;
            this.radioButtonUSkladistu.TabStop = true;
            this.radioButtonUSkladistu.Text = "U skladistu";
            this.radioButtonUSkladistu.UseVisualStyleBackColor = true;
            this.radioButtonUSkladistu.CheckedChanged += new System.EventHandler(this.radioButtonNarucen_CheckedChanged);
            // 
            // radioButtonNarucen
            // 
            this.radioButtonNarucen.AutoSize = true;
            this.radioButtonNarucen.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNarucen.Name = "radioButtonNarucen";
            this.radioButtonNarucen.Size = new System.Drawing.Size(66, 17);
            this.radioButtonNarucen.TabIndex = 0;
            this.radioButtonNarucen.TabStop = true;
            this.radioButtonNarucen.Text = "Narucen";
            this.radioButtonNarucen.UseVisualStyleBackColor = true;
            this.radioButtonNarucen.CheckedChanged += new System.EventHandler(this.radioButtonNarucen_CheckedChanged);
            // 
            // checkBoxHitno
            // 
            this.checkBoxHitno.AutoSize = true;
            this.checkBoxHitno.Location = new System.Drawing.Point(12, 234);
            this.checkBoxHitno.Name = "checkBoxHitno";
            this.checkBoxHitno.Size = new System.Drawing.Size(51, 17);
            this.checkBoxHitno.TabIndex = 12;
            this.checkBoxHitno.Text = "Hitno";
            this.checkBoxHitno.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 186);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 435);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxHitno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownBrojPaketa);
            this.Controls.Add(this.numericUpDownPUP);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vezba 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPaketa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.NumericUpDown numericUpDownPUP;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojPaketa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUProdaji;
        private System.Windows.Forms.RadioButton radioButtonUSkladistu;
        private System.Windows.Forms.RadioButton radioButtonNarucen;
        private System.Windows.Forms.CheckBox checkBoxHitno;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
    }
}

