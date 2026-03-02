using static Projeto_BancoCentral_.Transacao;
using System;
using Projeto_BancoCentral_;

class Program
{
    static void Main(string[] args)
    {
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@gmail.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;

        Console.WriteLine($"Pix de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");

        Console.WriteLine("\nRelatório em Milhoes:");
        ExibirRelatorio(meuPix.Valor, new ConversorMilhoes());

        Console.WriteLine("\nRelatório em Bilhões:");
        ExibirRelatorio(meuPix.Valor, new ConversorBilhoes());

        Console.WriteLine("\nRelatório em Trilhões:");
        ExibirRelatorio(meuTed.Valor, new ConversorTrilhoes());

        Console.ReadLine();
    }

    public static void ExibirRelatorio(decimal valorBruto, IConversorGrandeza conversor)
    {
        decimal valorConvertido = conversor.Converter(valorBruto);
        Console.WriteLine($"Valor convertido: {valorConvertido:N2} {conversor.ObterSimbolo()}");
    }//teste//teste
}
