namespace Alura.Filmes;
public class Artista
{
    public Artista(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<string> filmesAtuados = new();

    public void AddFilmeAtuado(string filme)
    {
        filmesAtuados.Add(filme);
    }
    public void listarFilmesAtuados()
    {
        System.Console.WriteLine($"Filmes atuados pelo ator {Nome}:");
        foreach (var filme in filmesAtuados)
        {
            System.Console.WriteLine(filme);
        }
        System.Console.WriteLine("\n");
    }
}
