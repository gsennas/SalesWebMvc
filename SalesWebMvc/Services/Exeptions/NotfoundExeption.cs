using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exeptions
{
    public class NotfoundExeption : ApplicationException
    {
        public NotfoundExeption (string message) : base(message)
        {
        }
        
    }
}
