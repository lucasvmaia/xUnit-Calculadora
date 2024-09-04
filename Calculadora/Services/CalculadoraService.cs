using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraService
    {
        private List<string> listHistorico;
        public CalculadoraService()
        {
            listHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            listHistorico.Insert(0, $"{num1 + num2}");
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            listHistorico.Insert(0, $"{num1 - num2}");
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            listHistorico.Insert(0, $"{num1 * num2}");
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            listHistorico.Insert(0, $"{num1 / num2}");
            return num1 / num2;
        }

        public List<string> Historico()
        {
            listHistorico.RemoveRange(3, listHistorico.Count - 3);
            return listHistorico;
        }
    }
}