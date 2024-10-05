using StudentNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class StudentInfoFRM : Form
    {
        public StudentInfoFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create object
            StudentInfo studentInfo1 = new StudentInfo();
            StudentInfo studentInfo2;

            if (studentIDtxtbox.Text != "" && lastNametxtbox.Text != "" && firstNametxtbox.Text != "")
            {
                //instantiate constructor
                studentInfo2 = new StudentInfo(studentIDtxtbox.Text, lastNametxtbox.Text, firstNametxtbox.Text);
                // add data to instance varible to class StudentInfo 
                StudentIDListBox.Items.Add(studentInfo2.StudentID);
                LastNameListBox.Items.Add(studentInfo2.StudentLastName);
                FirstNameListBox.Items.Add(studentInfo2.StudentFirstName);
            }
            else 
            {
                ClearInvalid.Visible = true; //show 'Clear Invalid' button to delete invalids  
                //add 'Invalid' if the input to 3 textboxes are empty
                StudentIDListBox.Items.Add(studentInfo1.StudentID);
                LastNameListBox.Items.Add(studentInfo1.StudentLastName);
                FirstNameListBox.Items.Add(studentInfo1.StudentFirstName);
            }
            clear();
        }
        //clear after data is inputted
        void clear() 
        {
            studentIDtxtbox.Clear();
            lastNametxtbox.Clear();
            firstNametxtbox.Clear();
        }
        //remove 'Invalid' if 'Clear Invalid button' shows
        private void ClearInvalid_Click(object sender, EventArgs e)
        {
            StudentIDListBox.Items.Remove("Invalid");
            LastNameListBox.Items.Remove("Invalid");
            FirstNameListBox.Items.Remove("Invalid");

            if ((!StudentIDListBox.Items.Contains("Invalid")) && (!FirstNameListBox.Items.Contains("Invalid")) && (!LastNameListBox.Items.Contains("Invalid"))) 
            {
                ClearInvalid.Visible = false;
            } 
        }
        // accept only numbers
        private void studentIDtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // accept only dots and letterss
        private void lastNametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space 
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        // accept only dots and letters
        private void firstNametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
