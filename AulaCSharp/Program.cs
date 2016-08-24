using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula = 10;
            string nome = "Cida";
            int idade = 30;

            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int numero = 1;
            do
            {
                Console.WriteLine(numero);
                numero--;
            } while (numero > 0);


            //while (numero > 0)
            //{
            //    Console.WriteLine(numero);
            //    numero--;
            //}

            //for (int i = 0; i < meses.Length; i++)
            //{
            //    Console.WriteLine("Exemplo: " + i);
            //}
            
            //foreach (int item in meses)
            //{
            //    Console.WriteLine("Mes: " + item);
            //}





            //switch (nome)
            //{
            //    case "Joao": Console.WriteLine("Bebe drinks");
            //        break;
            //    case "Maria": Console.WriteLine("Bebe Refrigerante");
            //        break;
            //    case "Leonardo":
            //    case "Cida": Console.WriteLine("Bebe agua");
            //        break;
            //    default: Console.WriteLine("Nao bebe nada");
            //        break;
            //}



            //if(idade > 17)
            //{
            //    Console.WriteLine("Joao pode beber drinks");
            //}
            //else if(idade > 2)
            //{
            //    Console.WriteLine("Joao pode beber refrigerante");
            //}
            //else
            //{
            //    Console.WriteLine("Joao bebe leite");
            //}

            //string resultado = idade > 17 ? "Liberado" : "Sensurado";
            //Console.WriteLine(resultado);


            Console.ReadLine();
        }

        static int Soma(int numero1, int numero2)
        {
            return (numero1 + numero2);
        }
    }
}
