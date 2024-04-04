using Alura.Filmes;

Filme filme1 = new("Homem Aranha: Longe de Casa");
Artista artista1 = new("Tom Holland");
filme1.AddElenco(artista1);

Filme filme2 = new("O Espetacular Homem Aranha");
Artista artista2 = new("Andrew Garfield");
filme2.AddElenco(artista2);

Filme filme3 = new("John Wick");
Artista artista3 = new("Keanu Reeves");
filme3.AddElenco(artista3);

Filme filme4 = new("O Rei do Show");
Artista artista4 = new("Zendaya");
filme4.AddElenco(artista4);

Filme filme5 = new("Velozes e Furiosos 7");
Artista artista5 = new("Vin Diesel");
filme5.AddElenco(artista5);

artista1.listarFilmesAtuados();
artista2.listarFilmesAtuados();
artista3.listarFilmesAtuados();
artista4.listarFilmesAtuados();
artista5.listarFilmesAtuados();






