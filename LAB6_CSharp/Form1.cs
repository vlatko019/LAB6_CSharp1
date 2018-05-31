using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Proizvod P = new Proizvod();
            P.DodajNaziv(textBoxNaziv.Text);
            P.SetBPUP(numericUpDownPUP.Value);
            P.SetBP(numericUpDownBrojPaketa.Value);
            if (radioButtonNarucen.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.Narucen);
            } else if (radioButtonUSkladistu.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.UProdaji);
            } else if (radioButtonUProdaji.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.USkladistu);
            }
            if (checkBoxHitno.Checked)
            {
                P.SetHitno();
            }
            listBox1.Items.Insert(listBox1.Items.Count, P.ReturnProizvod());
        }

        private void radioButtonNarucen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNarucen.Checked)
            {
                
                checkBoxHitno.Enabled = true;
            }
            else
            {
                checkBoxHitno.Checked = false;
                checkBoxHitno.Enabled = false;
            }
        }
        
    }
}
