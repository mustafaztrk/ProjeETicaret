using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool success, string message):this(success)//2. ctoru caıştırma kod tekrarına düşmemek için
        {
            Message = message;
            //Success = success;// 2. ctor üstünen çalıştırcaz
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
