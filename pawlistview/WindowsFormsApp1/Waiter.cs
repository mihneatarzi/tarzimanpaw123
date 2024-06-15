using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Waiter
    {
        private String nume;
        private int salary;
        private bool isFull;

        public string Nume { get => nume; set => nume = value; }
        public int Salary { get => salary; set => salary = value; }
        public bool IsFull { get => isFull; set => isFull = value; }

        public Waiter(string nume, int salary, bool isFull)
        {
            this.Nume = nume;
            this.Salary = salary;
            this.IsFull = isFull;
        }

        public Waiter() { }

        public override string ToString()
        {
            if (IsFull == true)
            {
                return "Angajatul" + Nume + "e  full time cu salariu" + Salary;
            }
            else return "Angajatul" + Nume + "nu e full time cu salariu" + Salary;
        }






    }
}
