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
        int pagCurenta;
        public List<Professor> lista = new List<Professor>();


        public Form1()
        {
            InitializeComponent();
            Professor p1 = new Professor(1, "Ilona", 9000.21);
            Professor p2 = new Professor(2, "Marius", 4000.21);
            Professor p3 = new Professor(3, "Popescu", 7000.21);
            Professor p4 = new Professor(4, "Stan", 8000.21);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);     
            lista.Add(p4);

            p3.Premiaza();

            foreach (Professor p in lista)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = p.Marca;
                row.Cells[1].Value = p.Nume;
                row.Cells[2].Value = p.Salariu;
                dataGridView1.Rows.Add(row);

            }

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            double sumasalarii = 0;
            foreach(Professor p in lista)
            {
                sumasalarii += p;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private int elementCurent = 0;
        private int elementePePagina = 0;
        private int elementePePaginaMax = 0;

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; 
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                pagCurenta = 0;
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            while (elementCurent<lista.Count)
            {
                Professor p = lista[elementCurent];
                e.Graphics.DrawString(p.Nume, new Font("Arial", 20, FontStyle.Bold),
                    Brushes.Black, 150, 100 + 40 * i);
                i++;
                elementCurent++;
                elementePePagina++;

                if (elementePePagina > elementePePaginaMax)
                {
                    elementePePagina = 0;
                    e.HasMorePages = true;
                    return;
                }


            }
            e.HasMorePages = false;
        }
    }
}
