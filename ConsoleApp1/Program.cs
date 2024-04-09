using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double md = 0;
            double ma = 0;
            double me = 0;
            double mm = 0;
            double continuar = 1;
            

            while (continuar == 1)
            {

                Console.WriteLine("Total de matrículas: ");
                Console.WriteLine("Desenvolvimento de Sistemas: " + md);
                Console.WriteLine("Administração: " + ma);
                Console.WriteLine("Edificações: " + me);
                Console.WriteLine("Mecatrônica: " + mm);

                Console.WriteLine("Insira o curso desejado: D = Desenvolvimento de Sistemas , A = Administração , E = Edificações , M = Mecatrônica");
                string matricula = Console.ReadLine().ToUpper();
                
                if (matricula == "D" && md <= 4)
                {
                    Console.WriteLine("O cuso escolhido foi Desenvolvimento de Sistemas. Matricula realizada com sucesso!");
                    md = md + 1;
                }
                else if (matricula == "D" && md >= 5)
                {

                    Console.WriteLine("O curso escolhido foi Desenvolvimento de Sistemas. Infelizmente não há mais vagas disponíveis");
                }
                if (matricula == "A" && ma <= 4)
                {
                    Console.WriteLine("O cuso escolhido foi Administração. Matricula realizada com sucesso!");
                    ma = ma+ 1;
                }
                else if (matricula == "A" && ma >= 5)
                {

                    Console.WriteLine("O curso escolhido foi Administração. Infelizmente não há mais vagas disponíveis");
                }
                if (matricula == "E" && me <= 4)
                {
                    Console.WriteLine("O cuso escolhido foi Edificações. Matricula realizada com sucesso!");
                    me = me + 1;
                }
                else if (matricula == "E" && me >= 5)
                {

                    Console.WriteLine("O curso escolhido foi Edificações. Infelizmente não há mais vagas disponíveis");
                }
                if (matricula == "M" && mm <= 4)
                {
                    Console.WriteLine("O cuso escolhido foi Mecatrônica. Matricula realizada com sucesso!");
                    mm = mm + 1;
                }
                else if (matricula == "M" && mm >= 5)
                {

                    Console.WriteLine("O curso escolhido foi Mecatrônica. Infelizmente não há mais vagas disponíveis");

                }



                Console.WriteLine("Você deseja repetir novamente? 1 = sim, 0 = não");
                    continuar = int.Parse(Console.ReadLine());


                
                Console.ReadKey();
            }
        }
    }
}