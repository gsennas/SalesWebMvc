using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exeptions
{
    public class DBCurrencyException: ApplicationException
    {
        public DBCurrencyException (string message) : base(message)
        {

        }
    }
}
