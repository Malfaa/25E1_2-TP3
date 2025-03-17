namespace TP3.Exercicio5;

public class Ingresso
{
    public string NomeDoShow = string.Empty;
    public double Preco;
    public int QuantidadeDisponivel;

    
    public string GetNomeDoShow()
    {
        return NomeDoShow;
    }
    public double GetPreco()
    {
        return Preco;
    }
    public int GetQuantidadeDisponivel()
    {
        return QuantidadeDisponivel;
    }
    
    
    public void SetNomeDoShow(string value)
    {
        NomeDoShow = value;
    }
    public void SetPreco(double value)
    {
        Preco = value;
    }
    public void SetQuantidadeDisponivel(int value)
    {
        QuantidadeDisponivel = value;
    }
	
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
    
    /*
            Esses métodos servem para ter um controle melhor sobre os valores dos atributos,
            evitando possíveis alterações de tipo, alterações no nome da variável etc, é uma
            boa prática para manter concizo a alteração de valores das próprias váriaveis.
            Futuramente com o uso de modificador de visibilidade, o get e o set se tornam
            um meio de acesso aos atributos que possam estar privados para uma única classe.
        */
}