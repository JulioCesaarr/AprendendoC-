using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class program
    {
        static void UsarStreamDeEntrada()
        {
            using (var FluxoDeEntrada = Console.OpenStandardInput())
            using(var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                

                while (true)
                {
                    var BytesLidos = FluxoDeEntrada.Read(buffer, 0, 1024);

                    fs.Write(buffer, 0, BytesLidos);
                    fs.Flush();
                   
                    Console.WriteLine($"Bytes Lidos Da Console {BytesLidos}");
                }
                
            }
        }

    }
}
