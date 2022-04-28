using ByteBankImportacaoExportacao.Modelos;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    { 
      static void LidandoComFileStreamsDiretamente()
      {
            var EnderecoDoArquivo = "contas.txt.txt";

            using (var FluxoDeArquivo = new FileStream(EnderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var NumeroDeBytesLidos = -1;

                while (NumeroDeBytesLidos != 0)
                {
                    NumeroDeBytesLidos = FluxoDeArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, NumeroDeBytesLidos);
                }


            }
      }
      static void EscreverBuffer(byte[] buffer, int bytesLidos)
      {
            var utf8 = new UTF8Encoding();

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            //foreach(var meubyte in buffer)
            //{
            //    Console.WriteLine(meubyte);
            //    Console.WriteLine(" ");
            //}
      }
    }
}