using ByteBankImportacaoExportacao.Modelos;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class program
    {
        static void criarArquivo()
        {
            var CaminhoNovoArquivo = "contasExportadas.csv";

            using (var FluxoDeArquivo = new FileStream(CaminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,123123,2424.44, Gustavo Santos";
                var encoding = new UTF8Encoding();
               
                var bytes = encoding.GetBytes(contaComoString);
               
                FluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }

        }
         
        static void CriarArquivoComWriter()
        {
            var CaminhoNovoArquivo = "contasExportadas.csv";

            using (var FluxoDeArquivo = new FileStream(CaminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(FluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456, 123223, 2424.44, Paulo César");
            }
        }

        static void TestaEscrita()
        {
            var caminhosArquivo = "Teste.txt";

            using(var FluxoDeArquivo = new FileStream(caminhosArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(FluxoDeArquivo))
            {
                for(int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush();

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais um!");
                    Console.ReadLine();
                }
                
                
            }
        }
    }
    
        
}