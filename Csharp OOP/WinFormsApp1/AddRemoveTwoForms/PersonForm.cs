using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRemoveTwoForms
{
    public partial class PersonForm : Form
    {
        
        public PersonForm()
        {
            InitializeComponent();
        }
        private Person person;
        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
                textName.Text = person.PersonName;
                textNumber.Text = person.PersonNumber;
            }
        }
        private void okBButton_Click(object sender, EventArgs e)
        {
            Person.PersonName = textName.Text;
            Person.PersonNumber = textNumber.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
