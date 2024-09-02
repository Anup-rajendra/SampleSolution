using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp;
namespace MyApp.Tests
{
    public class CalculatorTest
    {
        [Test]
        public void Add_Test()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Add_Test2()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }
    }
}
