using System;

namespace Holerite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            CalculadoraIrrf();


        }

        static void  CalculadoraIrrf()
        {
           
            double beneficios = 0;
            double irrf = 0;
            double vlHora = 0;
            double numHoras = 0;
            double inss = 0 ;
            string nome;
            

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Dgite o valor da hora trabalhada: R$");
            vlHora = double.Parse(Console.ReadLine());

        
            Console.Write("Digite o numero de horas trabalhadas: ");
            numHoras = double.Parse(Console.ReadLine());

            Console.Write("Caso recebe beneficios declare o valor total: R$");
            beneficios = double.Parse(Console.ReadLine());

            Console.Clear();

            double salarioBruto = (numHoras * vlHora );
            Console.WriteLine("Nome: "+ nome);
            Console.WriteLine("salario Bruto: R$"+ salarioBruto);
            Console.WriteLine("horas trabalhadas: " + numHoras);
            Console.WriteLine("Valor da hora trabalhada: R$" + vlHora);
            Console.WriteLine("Valor dos beneficios: R$" + beneficios);            
            
             if(salarioBruto <= 1903)

            {
            
                Console.WriteLine("seu desconto do irrf foi de: R$0");
                Console.WriteLine("ISENTO DE COBRANÇA");
                
            }
            else if(salarioBruto <= 2826)
            {

                irrf = (salarioBruto * 0.075) - 142.80;
                Console.WriteLine("seu desconto do irrf foi de: R$" + irrf.ToString("F2"));
                Console.WriteLine("Sua parcela a deduzir é: R$142.80");
                
            }
            else if(salarioBruto <= 3751)
            {
                irrf = (salarioBruto * 0.15) - 354.80;
        
                Console.WriteLine("seu desconto do irrf foi de: R$" + irrf.ToString("F2"));
                Console.WriteLine("Sua parcela a deduzir é de: R$354.80");
            }
            else if(salarioBruto <= 4664)
            {
                irrf = (salarioBruto * 0.225) - 636.13;
                Console.WriteLine("seu desconto do irrf foi de: R$" + irrf.ToString("F2"));
                Console.WriteLine("Sua parcela a deduzir é de: R$636.13");
            }
            else
            {
                irrf = (salarioBruto * 0.275) - 869.36;
                
                Console.WriteLine("seu desconto do irrf foi de: R$" + irrf.ToString("F2"));
                Console.WriteLine("Sua parcela a deduzir é de: R$869.36");
            }

            double salario = numHoras * vlHora;
            double descontos = (salarioBruto - irrf - inss);
            if (salario <= 1045)
            {
               inss = (salario * 0.07);

                Console.WriteLine("Desconto inss: R$" + inss.ToString("F2"));
            }
            else if(salario <= 2089)
            {
                inss = (salario * 0.09);
                Console.WriteLine("Desconto inss: R$" + inss.ToString("F2"));
            }
            else if(salario <= 3134)
            {
                inss = (salario * 0.12);
                Console.WriteLine("Desconto inss: R$" + inss.ToString("F2"));
            }
            else if(salario <= 6101)
            {
                inss = (salario * 0.14);
                Console.WriteLine("Desconto inss: R$" + inss.ToString("F2"));

            }
            else
            {
                inss = (salario = 6101.06  * 0.14);
                Console.WriteLine("Desconto inss: R$" + inss.ToString("F2"));
            }

            double salarioLiquido = (salarioBruto - irrf -inss) + beneficios;

            Console.WriteLine("Salario liquido a receber: R$" + salarioLiquido.ToString("F2"));



            Console.ReadKey();
            

        }
    }
}
