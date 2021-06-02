using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espeleta_ContactTracing
{
    public partial class sub1 : Form
    {
        public sub1()
        {
            InitializeComponent();
        }
        private void create_file_Click(object sender, EventArgs e)
        {

            StreamWriter user_info;
            user_info = File.AppendText($"{last_name.Text}" + $"{first_name.Text}.txt");
            user_info.WriteLine("COVID POSITIVE INFORMATION");
            user_info.WriteLine("Name: " + $"{last_name.Text}, " + $"{first_name.Text}" + $"{middle_name}");
            user_info.WriteLine("Birthdate: " + $"{birthdate.Text}");
            user_info.WriteLine("Age: " + $"{age.Text}");
            user_info.WriteLine("Sex: " + $"{sex.Text}");
            user_info.WriteLine("Contact Number: " + $"{contact_number.Text}");
            user_info.WriteLine("Address: " + $"{address.Text}");
            user_info.Close();
   
        }
    } 
}

