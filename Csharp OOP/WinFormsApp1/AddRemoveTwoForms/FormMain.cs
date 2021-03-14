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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var fp = new PersonForm();
            fp.Person = new Person();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                listPerson.Items.Add(fp.Person);
            }
           
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listPerson.SelectedItem == null)
            {
                return;
            }
            listPerson.Items.Remove(listPerson.SelectedItem);
        }

        private void listPerson_DoubleClick(object sender, EventArgs e)
        {
            
            if (listPerson.SelectedItem == null)
            {
                return;
            }
            var fp = new PersonForm();
            fp.Person = (Person)listPerson.SelectedItem;
            fp.ShowDialog();
        }
    }
}
