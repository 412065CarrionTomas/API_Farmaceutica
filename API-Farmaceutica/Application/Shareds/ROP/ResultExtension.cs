using System.Collections.Immutable;

namespace API_Farmaceutica.Application.Shareds.ROP
{
    //FABRICA DE RESULTADOS
    public static class ResultExtension
    {

        public static readonly Unit Unit = Unit.Value;

        public static Result<T> Success<T>(this T value) => new Result<T>(value);

        public static Result<T> Failure<T>(ImmutableArray<string> errors) => new Result<T>(errors);

        public static Result<T> Failure<T>(string error) => new Result<T>(ImmutableArray.Create(error));

        public static Result<Unit> Success() => new Result<Unit>(Unit);

        public static Result<Unit> Failure(ImmutableArray<string> errors) => new Result<Unit>(errors);

        public static Result<Unit> Failure(IEnumerable<string> errors) => new Result<Unit>(ImmutableArray.Create(errors.ToArray()));

        public static Result<Unit> Failure(string error) => new Result<Unit>(ImmutableArray.Create(error));
    }
}

/* 
Explicacion linea por linea:

 -"public static readonly Unit Unit = Unit.Value;" : lo unico que haces es
    referencia a la instancia ya creada desde Class.Unit, nada mas. Asi, cuando
    deba un metodo referenciar esa instancia, no tenga que llamar al
    metodo, si no al campo que ya hace referencia desde un mismo lugar.

 -"public static Result<T> Success<T>(this T value) => new Result<T>(value);" :
    Este metodo retorna un Result<T>, sin emabargo, podemos observar el que metodo
    trabaja con <T>, ya que esto le permite determinar al metodo que es generico en tiempo de uso.
    Si no recibiera <T>, deberiamos hacer uno especifico por cada tiempo de posible resultado.
    T se define al llamar al metodo.
    Ademas, la funcion de este metodo es devolver un Success sin tener que hacer explicito
    el valor de <T>, ya que lo infiere con this. es decir, 10.Success() -> T = int.
    Sin este metodo tendria que haber realizado: new Result<int>(10)

 -"public static Result<T> Failure<T>(ImmutableArray<string> errors) => new Result<T>(errors);" :
    Se lo pase a Claude y me dijo que estaba ok:
    "
        analicemos esta linea parte por parte: "public static Result<T> Failure<T>(ImmutableArray<string> errors) => new Result<T>(errors); " 
        Es un metodo que retorna "Result<T>". El metodo se llamara "Failure", sin embargo, se le agrega el "<T>" para declarlo como metodo generico. 
        Que nos permite que sea generico? que el tipo de valor con el que se trabaje, se defina al momento de llamarlo. 
        Este metodo ingresa por parametro "(ImmutableArray<string> errors)".  Como resultado del metodo, debera hacer "=> new Result<T>(errors);"
        , que significa? creamos un objeto Result<T> llamando al constructor 
        "public Result(ImmutableArray<string> errors) { 
        if (errors.Length == 0) throw new InvalidOperationException("Debes ingresar al menos un error"); 
        Errors = errors; Value = default(T); }" 
        y este sera retornado.

    "

 -"public static Result<Unit> Success() => new Result<Unit>(Unit);" :
    Este metodo retorna un Result<Unit>, es decir, el T = Unit = ausencia = <nada>. Ademas, es un resultado de exito, pues no tiene 
    parametros. Sin embargo es de exito por que al retorna el "=> new Result<Unit>(Unit)" se envia por parametro un T value. "

 -"public static Result<Unit> Failure(ImmutableArray<string> errors) => new Result<Unit>(errors);" :
    Este metodo retorna una Result<Unit>, es decir, T = Unit= Ausencia. Este resultado es de fallo, por que se le envia por parametro
    un InmutableArray<strin>, ademas, por definicion de la clase Result, el IsSuccess se establece como false y el T como default es null.

 -"public static Result<Unit> Failure(IEnumerable<string> errors) => new Result<Unit>(ImmutableArray.Create(errors.ToArray()));" :
    Este metodo retorna un Result<Unit>. Ademas indica fallo en la ejecucion, sin emabargo, vemos que recibe como parametro un IEnumerable.
    La clase result, tiene un campo que es InmutableArray, por ello, en alguna momento debemos parsear el IEnumerable y lo hacemos desde este punto.
    
 -"public static Result<Unit> Failure(string error) => new Result<Unit>(ImmutableArray.Create(error));" :
    Este metodo retorna un Result<Unit>. Indica fallo y ademas recibe un unico string. Luego hacemos el parse a 
    InmutableArray.

*/
