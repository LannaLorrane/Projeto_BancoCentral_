using Projeto_BancoCentral_;

Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    //Criando o projeto bancoaaaa
    Banco meuBanco = new Banco();
    meuBanco.Nome = "Banco do Brasil";
    meuBanco.CodigoBACEN = "001";

    //Conta Bancária
    ContaBancaria contaOrigem = new ContaBancaria();
    contaOrigem.Agencia = "1234";
    contaOrigem.NumeroConta = "56789-0";

    ContaBancaria contaDestino = new ContaBancaria();
    contaDestino.Agencia = "4321";
    contaDestino.NumeroConta = "98765-0";

    //Criando o objeto Transação
    Transacao minhaTransacao = new Transacao();
    minhaTransacao.Valor = 250.00m;
    minhaTransacao.Data = DateTime.Now;
    minhaTransacao.Tipo = "PIX";
    minhaTransacao.ContaOrigem = contaOrigem;
    minhaTransacao.ContaDestino = contaDestino;

    //Exibindo os dados na tela
    Console.WriteLine("---REGISTRO BACEN---");
    Console.WriteLine("Banco: " + meuBanco.Nome);
    Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
    Console.WriteLine("------------------------");
    Console.WriteLine("Conta Origem: " + contaOrigem.NumeroConta + " (Agência " + contaOrigem.Agencia + ")");
    Console.WriteLine("Conta Destino: " + contaDestino.NumeroConta + " (Agência " + contaDestino.Agencia + ")");
    Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
    Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
    Console.WriteLine("Data: " + minhaTransacao.Data);

}
