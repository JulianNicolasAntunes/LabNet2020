using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Tests
{
    [TestClass()]
    public class TerritoriesLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            Console.WriteLine("Buscando todos los territorios disponibles");
             
            Assert.Fail(/*context.Territories.ToList()*/);
        }

        [TestMethod()]
        public void GetOneTest()
        {
            Assert.Fail();
        }
    }
}