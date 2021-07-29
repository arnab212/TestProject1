using NUnit.Framework;
using ForTest;
using System;
using Moq;

namespace ForTest
{
    [TestFixture]
    public class Tests
    {
        Mock<Banking> bank;
       
        //Check C = new Check();
        Banking b = new Banking();
        [SetUp]
        public void Setup()
        {
            bank = new Mock<Banking>();
        }

        [Test]
        public void Mtest()
        {
            bank.Setup(x => x.withdraw(1000)).Returns(9000);
        }

        //[Test]
        //public void Test1()
        //{
        //    int res = C.add(3, 4);

        //    Assert.AreEqual(7,res);
        //}
        //[Test]
        //public void Withdraw()
        //{
        //    int res = b.withdraw(9000);

        //    Assert.AreEqual(1000, res);
        //}
        //[Test]
        //public void Deposit()
        //{
        //    int res = b.deposit(9000);

        //    Assert.AreEqual(19000, res);
        //}
        [Test]
        public void checktrue()
        {
            int res = b.demo(true);
            Assert.AreEqual(42, res);

        }
        [Test]
        public void checkfalse()
        {
            Assert.Throws<InvalidOperationException>(() => b.demo(false));

        }
    }
}