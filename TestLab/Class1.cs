using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace TestLab
{
    public class Class1
    {
        [Test]
        public void Sub2Minus5()
        {
            Operators calc = new Operators();
            var test = calc.Sub(2, 5);
            Assert.AreEqual(-3, test);
        }

        [Test]
        public void Sub0Minus0()
        {
            Operators calc = new Operators();
            var test = calc.Sub(0, 0);
            Assert.AreEqual(0, test);
        }

        [Test]
        public void Sub8Minus2()
        {
            Operators calc = new Operators();
            var test = calc.Sub(8, 2);
            Assert.AreEqual(6, test);
        }


        [Test]
        public void Sum2Plus2()
        {
            Operators calc = new Operators();
            var test = calc.Sum(2, 2);
            Assert.AreEqual(4, test);
        }

        [Test]
        public void Sum0Plus0()
        {
            Operators calc = new Operators();
            var test = calc.Sum(0, 0);
            Assert.AreEqual(0, test);
        }

        [Test]
        public void Sum21Plus9()
        {
            Operators calc = new Operators();
            var test = calc.Sum(21, 9);
            Assert.AreEqual(30, test);
        }

        [Test]
        public void Div0Div5()
        {
            Operators calc = new Operators();
            var test = calc.Div(0, 5);
            Assert.AreEqual(0, test);
        }

        [Test]
        public void Div10Div2()
        {
            Operators calc = new Operators();
            var test = calc.Div(10, 2);
            Assert.AreEqual(5, test);
        }

        [Test]
        public void Div6Div0()
        {
            Operators calc = new Operators();
            var test = calc.Div(8, 2);
            Assert.AreEqual(4, test);
        }

        [Test]
        public void Mul2Mul3()
        {
            Operators calc = new Operators();
            var test = calc.Mul(2, 3);
            Assert.AreEqual(6, test);
        }

        [Test]
        public void Mul0Mul2()
        {
            Operators calc = new Operators();
            var test = calc.Mul(0, 2);
            Assert.AreEqual(0, test);
        }

        [Test]
        public void Mul10Mu5()
        {
            Operators calc = new Operators();
            var test = calc.Mul(10, 5);
            Assert.AreEqual(50, test);
        }

    }
}
