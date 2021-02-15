using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this = bu--class'ın kendisi
        //Overloading
        public Result(bool success, string message):this(success)       //Tek parametreli constructor'a success yolla 
        {
            Message = message;
        }
        public Result(bool success)
        {           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }      //Constructor ile set edilebilir
    }
}
