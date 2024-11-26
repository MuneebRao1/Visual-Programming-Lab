using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
 



        public Form2(string cus,string country,string g,string s,string h)
        {
            InitializeComponent();
            this.label6.Text = cus;
            this.label7.Text = country;
            this.label8.Text = g;
            this.label9.Text = s;
            this.label10.Text = h;

        }
        




        private void Form2_Load(object sender, EventArgs e)
        {


        }
    }
}
