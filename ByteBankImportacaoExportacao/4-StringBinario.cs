using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class program
    {
        static void EscritaBinario()
        {
            using (var fs = new FileStream("contacorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(312);
                escritor.Write(141234);
                escritor.Write(4000.50);
                escritor.Write("Maria Solidade");
            }
                  
        }
        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contacorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var SaldoConta = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia} / {numeroConta} / {SaldoConta} / {titular}");
            }
        }
          
    }
}
