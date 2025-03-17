namespace TP3.Exercicio3;

public class Ingresso
{
    public string? NomeDoShow;
    public double Preco;
    public int QuantidadeDisponivel;
	
    public void AtualizarPreco(double novoPreco)
    {
        Preco = novoPreco;
    }
    public void AtualizarQuantidade(int novaQuantidade)
    {
        QuantidadeDisponivel = novaQuantidade;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {NomeDoShow}\nPreço: R${Preco}\nQuantidade de ingressos: {QuantidadeDisponivel}");
    }
	
}