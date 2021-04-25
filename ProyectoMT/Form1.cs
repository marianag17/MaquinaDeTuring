using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMT
{

    public partial class Form1 : Form
    {
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptacion_Click(object sender, EventArgs e)
        {
            op = 1;
            this.Hide();
            var form2 = new Form2(op);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnfunciones_Click(object sender, EventArgs e)
        {
            op = 2;
            this.Hide();
            var form2 = new Form2(op);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btcdecision_Click(object sender, EventArgs e)
        {
            op = 3;
            this.Hide();
            var form2 = new Form2(op);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
