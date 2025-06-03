using NUnit.Framework;
using Microsoft.Playwright;
using OrangeHRM.Tests.Pages;
using System.Threading.Tasks;

namespace OrangeHRM.Tests.Tests
{
    [TestFixture]
    public class TestesDeLogin
    {
        private IBrowser _navegador;
        private IBrowserContext _contexto;
        private IPage _pagina;
        private PaginaDeLogin _paginaDeLogin;

        [SetUp]
        public async Task Inicializar()
        {
            var playwright = await Playwright.CreateAsync();
            _navegador = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _contexto = await _navegador.NewContextAsync();
            _pagina = await _contexto.NewPageAsync();

            _paginaDeLogin = new PaginaDeLogin(_pagina);
        }

        [Test]
        public async Task DeveFazerLoginComSucesso()
        {
            await _paginaDeLogin.AcessarPaginaAsync();
            await _paginaDeLogin.PreencherUsuario("Admin");
            await _paginaDeLogin.PreencherSenha("admin123");
            await _paginaDeLogin.ClicarEmEntrar();

            await _pagina.WaitForURLAsync("**/dashboard/index");

            Assert.That(_paginaDeLogin.ObterUrlAtual(), Does.Contain("/dashboard/index"));
        }

        [TearDown]
        public async Task Finalizar()
        {
            await _navegador.CloseAsync();
        }
    }
}
