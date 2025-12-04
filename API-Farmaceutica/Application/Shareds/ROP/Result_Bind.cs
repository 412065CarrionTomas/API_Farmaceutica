using System.Runtime.ExceptionServices;

namespace API_Farmaceutica.Application.Shareds.ROP
{
    public static class Result_Bind
    {
        //recibo un valor sincronico y recibo un metodo asincronico
        public static async Task<Result<U>> Bind<T,U>(this Result<T> result, Func<T,Task<Result<U>>> method)
        {
            try
            {
                return result.IsSucces
                    ? await method(result.Value)
                    : ResultExtension.Failure<U>(result.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }
        
        //recibe un valor sincronico y recibo un metodo sincronico
        public static Result<U> Bind<T,U>(this Result<T> result, Func<T,Result<U>> method)
        {
            try
            {
                return result.IsSucces
                    ? method(result.Value)
                    : ResultExtension.Failure<U>(result.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }
        
        //recibo un valor asincronico y recibo un metodo asincronico 
        public static async Task<Result<U>> Bind<T, U>(this Task<Result<T>> result, Func<T, Task<Result<U>>> method)
        {
            try
            {
                Result<T> r = await result;
                return r.IsSucces
                    ? await method(r.Value)
                    : ResultExtension.Failure<U>(r.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        //recibo un valor asincronico y recibo un metodo sincronico
        public static async Task<Result<U>> Bind<T,U>(this Task<Result<T>> result, Func<T, Result<U>> method)
        {
            try
            {
                Result<T> r = await result;
                return r.IsSucces
                    ? method(r.Value)
                    : ResultExtension.Failure<U>(r.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

    }

}

/* Explicacion linea por linea
 public static async Task<Result<U>> Bind<T, U>(this Task<Result<T>> result, Func<T, Task<Result<U>>> method) :
    Este metodo asincronico devuelve un Result<U> (es de la misma clase Result). El nombre del metodo viene acompañado con 
    dos variables generias, puesto que se van a inferir en tiempo de ejecucion. This obtiene "Result<T>. Gracias a Result<T>
    podemos inferir el Value T(sea un numero, string o clases). Sin emabargo, otra razon importante es el aplicar metodo de extension.
    Por otra parte, y muy importante "Func<T, Task<Result<U>>> method" Gracias a esa funcion, podemos enviar como parametro, un metodo.
    A esa funcion le ingresa un valor T y devuelve un Result<U> (ese Result<U> es el que va a retornar el metodo). 
    Por que recibe T? pues al concatenar metodos(propio de la logica ROP), podemos recibir un valor y devolver otro.
    Podemos recibir un T = int y devolver un U = string, podemos recibir T = UserAccount y devolver U = int.
    Y gracias a que podemos pasar metodos como parametros, podeos combinarlo de distintas maneras.
    Otra parte a tener en cuenta es esta "return r.IsSucces
                    ? await method(r.Value)
                    : ResultExtension.Failure<U>(r.Errors);"
    Esto toma el IsSucces del campo Result y si es true, aplica el metodo(pasado por parametro)
    Si es false, devuelve un Result.Failure.
    Porque el "ResultExtension.Failure<U>(r.Errors);" recibe <U>? eso se debe por la firma. Si el exito devuelve U, y fallo devolviese T
    habria una falla.

 */


/* 
 * 
 *EXPLICACION OBTENIDA POR CLAUDE:
public static async Task<Result<U>> Bind<T, U>(this Task<Result<T>> result, Func<T, Task<Result<U>>> method):

Este método asíncrono retorna un Task<Result<U>> (tarea que contiene un Result<U>). 
Declara dos variables genéricas <T, U> que se infieren en tiempo de compilación según el contexto de uso.

El modificador 'this' cumple dos propósitos:
1. Define el método como extensión de Task<Result<T>>
2. Permite inferir el tipo T desde el resultado de entrada

El parámetro "Func<T, Task<Result<U>>> method" es clave en ROP porque:
- Permite pasar métodos como parámetros (programación funcional)
- Recibe un valor de tipo T
- Retorna una Task<Result<U>> (operación asíncrona)

¿Por qué recibe T y retorna U?
Para permitir TRANSFORMACIONES en el pipeline de Railway Oriented Programming:
- int → string (edad → "Mayor de edad")
- UserAccount → int (usuario → ID)
- string → Usuario (email → objeto Usuario)

Gracias a esta flexibilidad, podemos encadenar operaciones heterogéneas:
    await ObtenerUsuario()        // Task<Result<Usuario>>
        .Bind(u => ValidarPermisos(u))   // Task<Result<bool>>
        .Bind(ok => GenerarToken(ok));   // Task<Result<string>>
*/

