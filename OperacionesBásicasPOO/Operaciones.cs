using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesBásicasPOO
{
    public class Operaciones : Principal
    {
        private double suma, resta, multiplo, cociente; 

        public void calcularSuma()
        {
            this.suma = this.getNumero1() + this.getNumero2();
            
        }

        public void calcularResta()
        {
            this.resta = this.getNumero1() - this.getNumero2();
            
        }

        public void calcularMultiplo()
        {
            this.multiplo = this.getNumero1() * this.getNumero2();

        }

        public void calcularCociente()
        {
            this.cociente = this.getNumero1() / this.getNumero2();
            
        }

        public double getSuma()
        {
            return this.suma;
        }

        public double getResta()
        {
            return this.resta;
        }

        public double getMultiplo()
        {
            return this.multiplo;
        }

        public double getCociente()
        {
            return this.cociente;
        }
    }
}
