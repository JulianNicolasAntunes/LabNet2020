using Lab.Entities;
using Lab.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Lab.Logic
{
   public abstract class Logic
    {
        protected readonly NorthwindContext context;

        public Logic()
        {
            this.context = new NorthwindContext();
        }
    }
}
