using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace QuayTecnology
{
    public class QuayTransactionManager : TransactionScope
    {

    }

    class MyClass
    {
        public MyClass()
        {
            using (QuayTransactionManager manager = new QuayTransactionManager())
            {

                manager.Complete();
            }
        }
    }

}
