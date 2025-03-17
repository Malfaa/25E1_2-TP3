namespace TP3.Exercicio1;

// Declaração da classe Carro
public class Carro
{
    // Campos (atributos)
    public string Marca = "Hyundai";
    public string Modelo = "HB20";
    public int AnoFabricacao = 2020;
    public string Cor = "azul";	
	
    // Método para mudar a cor do carro
    public void MudarCorCarro(string novaCor){
        if(novaCor!= Cor){
            Cor = novaCor;
            Console.WriteLine($"Cor trocada! Nova Cor: {Cor}");
        }else{
            Console.WriteLine("Não é possível trocar pela mesma cor!");
        }
    }
}