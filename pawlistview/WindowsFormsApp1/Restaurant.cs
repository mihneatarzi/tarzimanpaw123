using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Restaurant
    {
        private string nume;
        private List<Waiter> waiters;

        public Restaurant()
        {
            Waiters = new List<Waiter>();
        }

        public string Nume { get => nume; set => nume = value; }
        public List<Waiter> Waiters { get => waiters; set => waiters = value; }
    }
}
