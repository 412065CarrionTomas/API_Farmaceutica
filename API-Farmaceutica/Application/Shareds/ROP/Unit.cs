namespace API_Farmaceutica.Application.Shareds.ROP
{
    //RESULTADO PARA TIPO VOID
    public class Unit
    {
        public static readonly Unit Value = new Unit();
        private Unit() { }
    }
}


/*  la clase Unit representa la ausencia de un valor, ya que el tipo Generic
 no maneja muy bien los valores de tipo void.
public static readonly Unit Value = new Unit(); genera una instancia unica
en tiempo de ejecucion de la clase Unit, es un singleton

 private Unit() { } un constructor que crea la clase Unit
es privado para evitar el uso desde fuera

 esto permite devolver exito o error sin ningun valor */
