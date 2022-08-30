using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração e instanciação dos objetos
            Aluno al = new Aluno(); 
            mensalidade men = new mensalidade();
            //chamada dos métodos
            Console.Write("Digite o nome: ");
            al.SetNome(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            al.SetEndereco(Console.ReadLine());
            Console.Write("Digite o CPF: ");
            al.SetCpf(Console.ReadLine());
            Console.Write("Digite o RA: ");
            al.SetRa(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o curso: ");
            men.SetCurso(Console.ReadLine());
            Console.Write("Digite o valor: ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o dia do pagamento: ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nDados do aluno");
            Console.WriteLine("RA: " + al.GetRa() + "\nAluno: " + al.GetNome());
            Console.WriteLine("Endereço: " + al.GetEndereco() + "\nValor da mensalidade: " + men.GetValor().ToString("C")+ 
                "\nValor a pagar: " + men.Calcular().ToString("C"));
            Console.ReadKey();


        }
    }
}
