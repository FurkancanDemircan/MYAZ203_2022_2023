using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public class Result
    {
        // Field

        // Property
        public bool Status { get; set; }
        public string Message { get; set; }

        // Methods
        public Result()
        {

        }

        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
