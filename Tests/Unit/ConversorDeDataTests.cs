using NUnit.Framework;
using System;

namespace OrangeHRM.Tests.Unit
{
    [TestFixture]
    public class ConversorDeDataTests
    {
        [Test]
        public void DeveConverterParaFormatoBrasileiro()
        {
            var data = new DateTime(2024, 12, 25);
            var resultado = ConversorDeData.ConverterParaFormatoBrasileiro(data);
            Assert.AreEqual("25/12/2024", resultado);
        }

        [Test]
        public void DeveConverterParaFormatoISO()
        {
            var data = new DateTime(2024, 12, 25);
            var resultado = ConversorDeData.ConverterParaFormatoISO(data);
            Assert.AreEqual("2024-12-25", resultado);
        }
    }
}
