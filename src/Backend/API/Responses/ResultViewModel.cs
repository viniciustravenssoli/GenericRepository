using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Responses
{
    public class ResultViewModel
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public dynamic Data { get; set; }
    }
}