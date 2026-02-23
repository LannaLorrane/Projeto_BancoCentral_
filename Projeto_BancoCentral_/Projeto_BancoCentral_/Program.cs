using static Projeto_BancoCentral_.Transacao;

class Program
{
    static void Main(string[] args)
    {
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@gmail.com";

        Transacaoted meuTed = new Transacaoted();
        meuTed.Valor = 6000;

        Console.WriteLine($"Pix de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");
    }
}

