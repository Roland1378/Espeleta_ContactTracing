using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espeleta_ContactTracing
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void positive_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub1 myForm = new sub1();
            myForm.ShowDialog();
            this.Close();
        }

        private void close_contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub2 myForm = new sub2();
            myForm.ShowDialog();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub3 myForm = new sub3();
            myForm.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
