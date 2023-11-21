using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnaranan_Click(object sender, EventArgs e)
        {
          string aranan=txtatlar.Text;
            int sayac = 0;
         for(int i = 0; i < lbatlar.Items.Count; i++)
            {
                if (aranan == lbatlar.Items[i].ToString()) ;
                sayac++;

            }if(sayac > sayac)
            {
                MessageBox.Show("sayac var");
            }
            else
            {
                MessageBox.Show("sayac yok");
            }
        }
    }
}
