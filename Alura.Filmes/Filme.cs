namespace Alura.Filmes;
public class Filme
{
    public Filme(string titulo)
    {
        Titulo = titulo;
    }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco = new();

    public void AddElenco(Artista artistaElenco)
    {
        Elenco.Add(artistaElenco);
        artistaElenco.AddFilmeAtuado(Titulo);
    }
}
