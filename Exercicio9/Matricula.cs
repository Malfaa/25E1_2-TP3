namespace TP3.Exercicio9;

public class Matricula{
    public string NomeAluno = string.Empty;
    public string Curso = string.Empty;
    public int NumeroMatricula;
    public string Situacao = string.Empty;
    public string DataInicial = string.Empty;
    
    public void TrancarMatricula()
    {
        Situacao = "Trancada";
    }
	
    public void ReativarMatricula()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Aluno: {NomeAluno}\nCurso: {Curso}\nSituação Atual: {Situacao}\n" +
                          $"Data Inicial Matricula: {DataInicial}");
    }
}