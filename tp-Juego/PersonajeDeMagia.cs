
namespace tp_Juego
{
    public class PersonajeDeMagia : Personaje
    {
        
        
        public PersonajeDeMagia(string parametroNombre, int parametroFuerza, int parametroAgilidad)
            {
                Nombre = parametroNombre;
                Fuerza = parametroFuerza;
                Agilidad = parametroAgilidad;
                Magia = 60;
            }

        public PersonajeDeMagia(string parametroNombre, int parametroFuerza, int parametroAgilidad, int parametroMagia)
        {
            {
                Nombre = parametroNombre;
                Fuerza = parametroFuerza;
                Agilidad = parametroAgilidad;
                Magia = parametroMagia;
            }
        }


        public override string Atacar()
        { 
            return $"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia";
        }

        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }
        
    }
}
