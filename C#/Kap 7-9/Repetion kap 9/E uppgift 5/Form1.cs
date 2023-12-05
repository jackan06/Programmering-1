using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_uppgift_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlumpa_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int antal = int.Parse(tbxAntal.Text);
            int[] tal=new int[antal];

            for (int i = 0; i < antal; i++)
            {
                tal[i]=random.Next(1,21);
                tbxResultat.AppendText(tal[i] + "\r\n");
            }

        }
    }
}
