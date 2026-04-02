using System.Net.WebSockets;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public Genero Genero { get; set; }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string NomeExibicao => $"{Nome}-{Artista}";

    public void ExibirInfoMusica()
    {
        Console.WriteLine(NomeExibicao);
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Canção disponível");
        }
        else
        {
            Console.WriteLine("Não disponível neste plano :/");
        }
    }

    /* public void ExibirInfoMusicaLimited()
     {
         Console.WriteLine($"Nome: {nome}");
         Console.WriteLine($"Artista: {artista}");
     }
 */

}