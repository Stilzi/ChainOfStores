using StoreChain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain.Classes
{
     public static class dbContext
    {
        public static ChainOfStoresEntities db = new ChainOfStoresEntities();
    }
}
