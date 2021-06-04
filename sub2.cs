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
    public partial class sub2 : Form
    {
        public sub2()
        {
            InitializeComponent();
        }

        private void create_file_Click(object sender, EventArgs e)
        {

            StreamWriter user_info;
            user_info = File.AppendText($"{last_name.Text}" + $"{first_name.Text}.txt");
            user_info.WriteLine("COVID CLOSE CONTACT");
            user_info.WriteLine("Name: " + $"{last_name.Text}, " + $"{first_name.Text} " + $"{middle_name.Text}");
            user_info.WriteLine("Birthdate: " + $"{birthdate.Text}");
            user_info.WriteLine("Age: " + $"{age.Text}");
            user_info.WriteLine("Sex: " + $"{sex.Text}");
            user_info.WriteLine("Contact Number: " + $"{contact_number.Text}");
            user_info.WriteLine("Address: " + $"{address.Text}");
            user_info.WriteLine("Relationship with COVID Positive: " + $"{relationship.Text}");
            user_info.WriteLine("Last close contact with COVID Positive: " + $"{last_meeting.Text}");
            user_info.WriteLine("Felt any symptoms in the last 14 days: " + $"{symptoms.Text}");
            user_info.WriteLine("Took a COVID Test: " + $"{test.Text}");
            user_info.WriteLine("Test Result: " + $"{result.Text}");
            user_info.Close();

            last_name.Text = "";
            first_name.Text = "";
            middle_name.Text = "";
            birthdate.Text = "";
            age.Text = "";
            sex.Text = "";
            contact_number.Text = "";
            address.Text = "";
            relationship.Text = "";
            last_meeting.Text = "";
            symptoms.Text = "";
            test.Text = "";
            result.Text = "";
        }

        private void search_file_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub3 myForm = new sub3();
            myForm.ShowDialog();
            this.Close();
        }

        private void back_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            main myForm = new main();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
