using tp_Juego;
PersonajeDeFuerza fuerte = new PersonajeDeFuerza("fuerte", 20, 30);
//Console.WriteLine(fuerte.CalcularDanio());
//Console.WriteLine(fuerte.Atacar());
PersonajeDeAgilidad agil = new PersonajeDeAgilidad("agil", 30, 10, 15);
//Console.WriteLine(agil.CalcularDanio());
//Console.WriteLine(agil.Atacar());



PersonajeDeMagia magico = new PersonajeDeMagia("magico 1", 20, 30);
PersonajeDeMagia magico2 = new PersonajeDeMagia("magico 2", 20, 30, 4);

//Console.WriteLine(magico.CalcularDanio());
//Console.WriteLine(magico.Atacar());

//Console.WriteLine(magico2.CalcularDanio());
//Console.WriteLine(magico2.Atacar());



//Console.WriteLine(magico2.MoverseEjeX());


Enemigo enemy = new Enemigo();

//Console.WriteLine(enemy.MoverseEjeY());
//Console.WriteLine(enemy.MoverseEjeX());


List<Personaje> personajes = new List<Personaje>();
personajes.Add(fuerte);
personajes.Add(magico);
personajes.Add(agil);

Turno.Atacarse(personajes);


List<IMoverse> lista = new();

lista.Add(fuerte);
lista.Add(magico);
lista.Add(agil);
lista.Add(new Enemigo());


foreach (IMoverse item in lista)
{
    Turno.MoverFichas(item);
  
}

