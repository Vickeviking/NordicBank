using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Transaction
    {
        // fields
       public int referenceFrom { get; }
       public int referenceTo { get; }
        public float amount { get; }
        public DateTime time { get; }

        public Transaction(int referenceTo, int referenceFrom, float amount, DateTime time)
        { 
            this.referenceTo = referenceTo;
            this.referenceFrom = referenceFrom;
            this.amount = amount;
            this.time = time;
        }



    }
}
