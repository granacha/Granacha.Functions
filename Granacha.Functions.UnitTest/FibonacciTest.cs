using NUnit.Framework;
using System.Linq;

namespace Granacha.Functions.UnitTest
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void When_I_Call_Calculate()
        {
            Assert.That(Fibonacci.Calculate(5), Is.EqualTo(5));
        }

        [Test]
        public void When_I_Call_GetNElements()
        {
            const int size = 5;
            var elements = Fibonacci.GetFirstNElements(size);
            Assert.That(elements.Count, Is.EqualTo(5));
            Assert.IsTrue(elements.Any(element => element.Equals(Fibonacci.Calculate(elements.IndexOf(element)))));
        }
    }
}
