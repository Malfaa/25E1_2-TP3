namespace TP3;

class Program
{
    // Método principal para testar a classe
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("4. Exercício 4");
            Console.WriteLine("5. Exercício 5");
            Console.WriteLine("6. Exercício 6");
            Console.WriteLine("9. Exercício 9");
            Console.WriteLine("12. Exercício 12");

            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Criação de um objeto da classe Carro
                    Exercicio1.Carro objCarro = new();
                    
                    // Usando o método para mudar a cor do carro
                    objCarro.MudarCorCarro("prata");
                    objCarro.MudarCorCarro("vermelho");
                    break;
                case 4:
                    Exercicio4.Ingresso ingresso4 = new();
                    ingresso4.NomeDoShow = "System of a Down";
                    ingresso4.Preco = 800.00;
                    ingresso4.QuantidadeDisponivel = 10000;
	
                    ingresso4.AtualizarPreco(1600.00);
                    ingresso4.AtualizarQuantidade(50);
                    ingresso4.ExibirInformacoes();
                    break;
                case 5:
                    Exercicio5.Ingresso ingresso5 = new();
	
                    ingresso5.NomeDoShow = "System of a Down";
                    ingresso5.Preco = 800.00;
                    ingresso5.QuantidadeDisponivel = 10000;

                    ingresso5.SetPreco(200.0);
                    Console.WriteLine(ingresso5.GetPreco());
                    break;
                case 6:
                    Exercicio6.Ingresso ingresso6 = new("System of a Down", 800.00, 10);

                    ingresso6.ExibirInformacoes();
	
                        /*
                       	O construtor orienta o programador a definir os atributos corretos, evita a necessidade de 
                       	chamar vários métodos "set" separadamente, o que pode levar a erros, como esquecer de definir 
                       	algum atributo ou inicializá-lo incorretamente. Além disso, o construtor garante que o objeto 
                       	seja criado em um estado válido desde o início.
                       */

                    break;
                case 9:
                    Exercicio9.Matricula matricula = new();
                    matricula.NomeAluno = "Gustavo";
                    matricula.Curso = "Engenharia de Software";
                    matricula.NumeroMatricula = 10110;
                    matricula.Situacao = "Ativo";
                    matricula.DataInicial = "22/08/2024";
		
                    matricula.ExibirInformacoes();
		
                    matricula.TrancarMatricula();
                    matricula.ExibirInformacoes();
		
                    matricula.ReativarMatricula();
                    matricula.ExibirInformacoes();
                    break;
                case 12:
                    Exercicio12.Circulo carea = new();
                    Exercicio12.Esfera cvol = new();
		
                    carea.Raio = 3.00;
                    cvol.Raio = 5.00;
		
                    Console.WriteLine($"Área do Círculo: {carea.CalcularArea()}m^2\nVolume da Esfera: {cvol.CalcularVolume()}m^3");
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}