using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram25Jan
{
    public class CabInvoiceException:Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        ExceptionType type;

        public CabInvoiceException(ExceptionType type,string message):base(message)
        {
            this.type = type;
        }
    }
}
