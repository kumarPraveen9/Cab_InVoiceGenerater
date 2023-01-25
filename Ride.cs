using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram25Jan
{
    public class Ride
    {
        public double distance;
        public int time;
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
