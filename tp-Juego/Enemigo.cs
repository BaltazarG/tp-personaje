
namespace tp_Juego
{
    public class Enemigo : IMoverse
    {
        public int vida;
        public int nivel;

        public Enemigo()
        {
            vida = 1000;
            nivel = 1;
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
