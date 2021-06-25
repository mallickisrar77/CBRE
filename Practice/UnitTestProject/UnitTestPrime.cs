using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;
using Moq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPrime
    {
        //readonly PrimeService _primeService;
        private readonly IPrimeService _primeService;
       public UnitTestPrime() => _primeService = new PrimeService();       

        [DataTestMethod,DataRow(-1),DataRow(0),DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value) =>
            Assert.IsFalse(_primeService.IsPrime(value), $"{value} should not be prime");

        [DataTestMethod, DataRow(2), DataRow(3), DataRow(5), DataRow(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value) =>
           Assert.IsTrue(_primeService.IsPrime(value), $"{value} should be prime");

        [DataTestMethod,DataRow(4), DataRow(6), DataRow(8), DataRow(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value) =>
            Assert.IsFalse(_primeService.IsPrime(value), $"{value} should not be prime");

    }
}
