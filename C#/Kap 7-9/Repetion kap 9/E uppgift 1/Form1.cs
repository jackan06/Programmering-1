using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_uppgift_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            int betalat = int.Parse(tbxBetalat.Text);
            char medlem = char.Parse(tbxMedlem.Text);

            if (medlem == 'j' &&  betalat >= 1000)
            {
                tbxRabatt.Text = "Du får rabatt";
            }
            else
            {
                tbxRabatt.Text = "Du får inte rabatt";
            }
        }
    }
}
