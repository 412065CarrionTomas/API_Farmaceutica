using System.Collections.Immutable;

namespace API_Farmaceutica.Application.Shareds.ROP
{
    //CLASE RESULT GENERICA
    public struct Result<T>
    {
        public readonly T Value;
        public readonly ImmutableArray<string> Errors;
        public static implicit operator Result<T>(T value) => new Result<T>(value);

        public bool IsSucces => Errors.Length == 0;
        
        public Result(T value)
        {
            Value = value;
            Errors = ImmutableArray<string>.Empty;
        }

        public Result(ImmutableArray<string> errors)
        {
            if (errors.Length == 0)
                throw new InvalidOperationException("Debes ingresar al menos un error");
            Errors = errors;
            Value = default(T);
        }
    }
}

/* definimos Result como tipo struct, ya que aporta distintos
 beneficio, entre ellos, inmutabilidad

Este objeto es un tipo Generico que recibe <T>

luego comenzamos con los campos:
-tenemos un campo T value, el cual es Readonly para reforzar
inmutabilidad. Este campo almacena el valor del resultado
-tenemos el campo ImmutableArray<string> Errors;,el cual es tambien
Readonly. Este almacena una lista de errores de tipo string
-por ultimo IsSuccess, el cual esta definido que: si Errors
esta vacio, el true, si no, false.

 El constructor public Result(T value) crea unicamente esto 
si fue exitoso. Recibe un T value, para asignar campos y 
define implicitamente al Erros como empaty, por ello IsSuccess
es True.

 public Result(ImmutableArray<string> errors) recibe un
array de errores. Al no ser vacio, IsSuccess es False, y
define explicitamente al campo Value como Default. Es decir,
si el valor e un int y hubo error, el Value es 0.
Si el valor es un string y hubo error, el Value es Empaty.
Ademas se valida que, si yo llamo a este metodo, si o si,
deba recibir un error, si no, no tendria sentido llamarlo.

 
public static implicit operator Result<T>(T value) => new Result<T>(value);
este campo nos facilita el codigo, para que sea mas legible.
Es del tipo public static para podes invocarlo desde donde yo quiera,
es implicit, asi no se debe especificar(ocurre la conversion automaticamente)
operator define la conversion explicita, en este caso "Result<T>.
Para que este casteo funcione automaticamente, previamente debemos especificarle al compilador cual es el Result<T> que queremos.
Es decir, si un metodo devuelve Result<UserAccount> , cualquier valor que retornemos, el compilador intenta hacer el cast implicito.
Si no conincide el cast, da error. Tambien sirve como paraemtro de metodos. Si especificamos en la firma del metodo que va a recibir
un Result<int>, el valor que pasemos luego para usar el parametro, el compilador hace el cast implicito. 
El compilador debe inferir el tipo.

 
EXPLICACION que le di a Claude 4.5 y dijo que fue correcta:

"   en base a esta linea: "public static implicit operator Result<T>(T value) => new Result<T>(value); "
    no me queda claro el fragmento "Result<T>(T value) => new Result<T>(value);", osea vamos parte por parte . 
    Esto vendria a ser un metodo? que es? por lo que entiendo "Result<T>" es el tipo de valor de retorno. 
    "(T value)" es lo que ingresa como parametro del metodo(el metodo no tiene nombre). 
    El resultado obtenido es un nuevo objeto de tipo Result<T> que llama al construtor 
    "public Result(T value) { Value = value; Errors = ImmutableArray<string>.Empty; }" 
    y le pasa por parametro el "value"(en esta parte:"=> new Result<T>(value);")    
"

Lo unico que me corrigio Claude es:"¿Es un método?
Técnicamente sí, pero es un método especial llamado operador. No tiene nombre tradicional porque su "nombre" es la conversión misma: 
T → Result<T>.
*/