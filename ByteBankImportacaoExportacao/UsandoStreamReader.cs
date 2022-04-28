using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStreamerReader()
        {
            var enderecoDoArquivo = "contas.txt.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);


                    var msg = $"{contaCorrente.Titular.Nome}: Conta Número: {contaCorrente.Numero}, ag = {contaCorrente.Agencia}. saldo: {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                }
            }



            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var AgenciaComoInt = int.Parse(agencia);
            var NumeroComoInt = int.Parse(numero);
            var SaldoComoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = nomeTitular;


            var resultado = new ContaCorrente(AgenciaComoInt, NumeroComoInt);
            resultado.Depositar(SaldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
