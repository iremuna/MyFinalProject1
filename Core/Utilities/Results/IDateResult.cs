using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDateResult<T>:IResult
    {
        T Data { get; }
    }
}
