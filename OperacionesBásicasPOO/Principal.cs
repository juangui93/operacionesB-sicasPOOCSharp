using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesBásicasPOO
{
    public class Principal
    {
        private double numero1, numero2;
        private string operacion; 
        

        public void setNumero1(double valor1)
        {
            this.numero1 = valor1; 
        }

        public void setNumero2(double valor2)
        {
            this.numero2 = valor2; 
        }

        public void setOperacion(string val)
        {
            this.operacion = val;
        }

        public double getNumero1()
        {
            return numero1; 
        }

        public double getNumero2()
        {
            return numero2; 
        }

        public string getOperacion()
        {
            return operacion; 
        }

    }
}
