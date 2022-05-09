
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
            mensaje = $"{Nombre} hizo {x} de daño gracias a su magia";
            return mensaje;
        }

        public override int CalcularDanio()
        {
            x = Fuerza + Agilidad + Magia * 4;
            return x;
        }
        
    }
}
