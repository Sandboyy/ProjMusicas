class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public string Produtor { get; set; }
    public int DuracaoTotal { get; set; }

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }


    public void ExibirInfoAlbum()
    {
        Console.WriteLine($"\nNome do Álbum: {Nome}");
        Console.WriteLine($"Duração do Álbum: {DuracaoTotal}\n");
        foreach (var musica in musicas)     //Uso o foreach com(var musica) pois vou passar por cada item da lista e ler cada propriedade da classe Musica
        {
            Console.WriteLine($"Nome da Música: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista.NomeBanda}");
            Console.WriteLine($"Duração: {musica.Duracao}\n");
        }
    }

    public int CalcularDuracaoAlbum()
    {
        foreach (var musica in musicas)
        {
            DuracaoTotal += musica.Duracao;
        }
        return DuracaoTotal;
    }
}