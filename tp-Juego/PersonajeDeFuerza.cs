
namespace tp_Juego
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string parametroNombre, int parametroAgilidad, int parametroMagia)
        {
            Nombre = parametroNombre;
            Agilidad = parametroAgilidad;
            Magia = parametroMagia;
            Fuerza = 100;
        }
        
        public override int CalcularDanio()
        {
            return ((Fuerza * 4) + (Agilidad * 3) + (Magia * 5)) * 3;
        }
    }
}
