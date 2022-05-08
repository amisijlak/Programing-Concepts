using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDDemo.Test
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void CalculatorTestAdd()
        {
            Calci calci = new Calci();
            int result = calci.Add(1, 2);
        }
    }
}