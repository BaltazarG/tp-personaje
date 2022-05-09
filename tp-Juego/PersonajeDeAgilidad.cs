
namespace tp_Juego
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string parametroNombre, int parametroAgilidad, int parametroMagia, int parametroFuerza)
        {
            Nombre = parametroNombre;
            Agilidad = parametroAgilidad;
            Magia = parametroMagia;
            Fuerza = parametroFuerza;
        }
        public override int CalcularDanio()
        {
            x = Fuerza / 2 * Agilidad * Magia / 2;
            return x;
        }
    }
}
