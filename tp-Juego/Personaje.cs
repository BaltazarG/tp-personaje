
namespace tp_Juego
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre="";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
       


        public virtual int CalcularDanio()
        {
            return 0;
        }
        public virtual string Atacar()

            {
                return $"{Nombre} hizo {CalcularDanio()} de daño";
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
