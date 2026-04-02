Album albumLP = new Album("Meteora");
Banda lp = new Banda("Linkin Park");



Musica musica1 = new Musica(lp, "Numb")
{
    Duracao = 200,
    Disponivel = true,
};


Musica musica2 = new Musica(lp, "Faint")
{
    Duracao = 350,
    Disponivel = true,
};


Musica musica3 = new Musica(lp, "From the Inside")
{
    Duracao = 124,
    Disponivel = true,
};




//musica1.ExibirInfoMusica();

albumLP.AddMusica(musica1);
albumLP.AddMusica(musica2);
albumLP.AddMusica(musica3);

lp.InsertAlbum(albumLP);

//lp.ExibirDiscografiaBanda();

albumLP.CalcularDuracaoAlbum();
albumLP.ExibirInfoAlbum();

