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
    public partial class sub3 : Form
    {
        public sub3()
        {
            InitializeComponent();

        }

        private void go_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            main myForm = new main();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
