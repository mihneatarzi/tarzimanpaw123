using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormWaiter : Form
    {
        public Waiter formWaiter = new Waiter();



        public FormWaiter()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try 
            {
                formWaiter.Nume = textboxnume.Text;
                formWaiter.IsFull = checkboxestefull.Checked;
                formWaiter.Salary = int.Parse(textBoxsalariu.Text);
            }
            catch
            {
                MessageBox.Show("eroare"); 
            }
            
        }

        private void FormWaiter_Load(object sender, EventArgs e)
        {

        }

        private void textboxnume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textboxnume, "");
        }

        private void textboxnume_Validating(object sender, CancelEventArgs e)
        {
            if (textboxnume.Text.Length < 4)
            {
                errorProvider1.SetError(textboxnume, "name is too short");
                e.Cancel = true;
            }
        }
    }
}
