using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class program
    {
       static void Main(string[] args)
        {
            var linhas = File.ReadAllLines("contas.txt.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
            
            Console.ReadLine();


            


            UsarStreamDeEntrada();
            Console.WriteLine("Aplicação Finalizada...");

            Console.ReadLine();
        }
    }
}
