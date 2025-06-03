using NUnit.Framework;
using OrangeHRM.Utils;

namespace OrangeHRM.Tests.Unit
{
    [TestFixture]
    public class ValidadorDeSenhaTests
    {
        [Test]
        public void DeveRetornarFalsoParaSenhaVazia()
        {
            var resultado = ValidadorDeSenha.SenhaEhForte("");
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeveRetornarFalsoParaSenhaSemLetraMaiuscula()
        {
            var resultado = ValidadorDeSenha.SenhaEhForte("senha123!");
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeveRetornarFalsoParaSenhaSemNumero()
        {
            var resultado = ValidadorDeSenha.SenhaEhForte("SenhaSegura!");
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeveRetornarVerdadeiroParaSenhaForte()
        {
            var resultado = ValidadorDeSenha.SenhaEhForte("Senha123!");
            Assert.IsTrue(resultado);
        }
    }
}
