using System;

namespace _20_11_Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Saudacao();

            Console.WriteLine("Digite uma operação");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero");
            float num1= float.Parse( Console.ReadLine() ) ;

            Console.WriteLine("Digite o segundo numero");
            float num2 = float.Parse( Console.ReadLine() ) ;


            switch (operacao)
            {
                case "Soma":
                // var resultado = num1 + num2;
                Soma(num1, num2);
                break;

            case "Subtrair":
                Subtrair(num1, num2);
                break;

            default:
                break;
            }

            string[] nomes = {"Carlos", "Paulo", "Pricila", "Lemos", "Thiago"};

            ListarProfessores( nomes );
        }
    }
}
