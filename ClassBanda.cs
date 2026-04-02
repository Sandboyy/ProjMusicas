class Banda
{

    public Banda(string nome)
    {
        NomeBanda = nome;
    }
    private List<Album> albums = new List<Album>(); //Como uma banda pode ter vários álbuns, eu instancio ele como lista
    public string NomeBanda { get; }

    public void InsertAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografiaBanda()
    {
        Console.WriteLine($"Banda: {NomeBanda}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome}");
        }
    }
}