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
