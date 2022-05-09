
namespace tp_Juego
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre="";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public int x;
        public string mensaje = "";
       


        public virtual int CalcularDanio()
        {
            return x;
        }
        public virtual string Atacar()

            {
                mensaje = $"{Nombre} hizo {x} de daño";
                return mensaje;
            }
        public string MoverseEjeX()
        {
            return "Moviendose sobre el eje X";
        }

        public string MoverseEjeY()
        {
            return "Moviendose sobre el eje Y";
        }
    }
}
