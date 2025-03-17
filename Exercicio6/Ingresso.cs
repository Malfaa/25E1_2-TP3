namespace TP3.Exercicio6;

public class Ingresso
{
    public string NomeDoShow;
    public double Preco;
    public int QuantidadeDisponivel;
	
    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel){
        NomeDoShow = nomeDoShow;
        Preco = preco;
        QuantidadeDisponivel = quantidadeDisponivel;
    }
    
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {NomeDoShow}\nPreço: R${Preco}\nQuantidade de ingressos: {QuantidadeDisponivel}");
    }
}	