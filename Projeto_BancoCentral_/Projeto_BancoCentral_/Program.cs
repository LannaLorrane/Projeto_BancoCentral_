using static BancoCentralAtual.Transacao;


using System;
using BancoCentralAtual;

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

        Console.ReadLine();
    }
}