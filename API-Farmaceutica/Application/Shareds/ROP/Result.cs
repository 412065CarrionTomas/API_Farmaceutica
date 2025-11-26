using System.Collections.Immutable;

namespace API_Farmaceutica.Application.Shareds.ROP
{
    public struct Result<T>
    {
        public readonly T Value;

        public static implicit operator Result<T>(T value) => new Result<T>(value);

        public readonly ImmutableArray<string> Errors;
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
