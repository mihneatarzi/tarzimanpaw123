using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IPremiere
    {
        void Premiaza();
    }
    public class Professor
    {
        private int marca;
        private string nume;
        private double salariu;

        public Professor(int marca, string nume, double salariu)
        {
            this.Marca = marca;
            this.Nume = nume;
            this.Salariu = salariu;
        }

        public int Marca { get => marca; set => marca = value; }
        public string Nume { get => nume; set => nume = value; }
        public double Salariu { get => salariu; set => salariu = value; }

     //   public int getMarca() { return Marca; }
      //  public string getNume() {  return Nume; }
     //   public double getSalariu() {  return Salariu; }

        public static double operator+(double expresie,Professor professor)
        {
            return expresie + professor.salariu;
        }

        public void Premiaza()
        {
            this.salariu = this.salariu * 1.3;
        }

    }
}
