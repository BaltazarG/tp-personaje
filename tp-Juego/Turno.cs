
namespace tp_Juego
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            personajes.Select(personaje => personaje.Atacar());
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
              
    }
}
