using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //Exception personalisada
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
