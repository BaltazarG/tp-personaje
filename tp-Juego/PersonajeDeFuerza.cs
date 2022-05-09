
namespace tp_Juego
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string name, int agility, int magic)
        {
            Nombre = name;
            Agilidad = agility;
            Magia = magic;
            Fuerza = 100;
        }
        
        public override int CalcularDanio()
        {
            x = ((int)(((Fuerza * 4) + (Agilidad * 1.2) + (Magia * 5)) * 3));
            return x;
        }
    }
}
