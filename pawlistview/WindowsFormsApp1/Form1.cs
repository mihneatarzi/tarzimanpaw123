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
    public partial class Form1 : Form
    {


        Restaurant r1= new Restaurant();



        public Form1()
        {
            InitializeComponent();

        }

        private void addWaiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWaiter fw = new FormWaiter();
            if(fw.ShowDialog() == DialogResult.OK )
            {
                r1.Waiters.Add(fw.formWaiter);
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(fw.formWaiter.Nume);
                lvi.SubItems.Add(fw.formWaiter.Salary.ToString());
                if(fw.formWaiter.IsFull==true)
                {
                    lvi.SubItems.Add("yes");
                }
                else
                {
                    lvi.SubItems.Add("no");
                }
                lvi.Tag= fw.formWaiter;
                listView1.Items.Add(lvi);

                 

            }
            
        }
    }
}
