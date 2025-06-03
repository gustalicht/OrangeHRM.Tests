using NUnit.Framework;
using Microsoft.Playwright;
using OrangeHRM.Tests.Pages;
using System.Threading.Tasks;

namespace OrangeHRM.Tests.Tests
{
    [TestFixture]
    public class TestesDeLoginEDashboard
    {
        private IBrowser _navegador;
        private IBrowserContext _contexto;
        private IPage _pagina;
        private PaginaDeLogin _paginaDeLogin;
        private PaginaDoDashboard _paginaDoDashboard;

        [OneTimeSetUp]
        public async Task SetupGeral()
        {
            var playwright = await Playwright.CreateAsync();
            _navegador = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _contexto = await _navegador.NewContextAsync();
            _pagina = await _contexto.NewPageAsync();

            _paginaDeLogin = new PaginaDeLogin(_pagina);
            _paginaDoDashboard = new PaginaDoDashboard(_pagina);

            // Login executado uma vez para todos os testes da classe
            await _paginaDeLogin.AcessarPaginaAsync();
            await _paginaDeLogin.PreencherUsuario("Admin");
            await _paginaDeLogin.PreencherSenha("admin123");
            await _paginaDeLogin.ClicarEmEntrar();

            await _pagina.WaitForURLAsync("**/dashboard/index");
        }

        [Test, Order(1)]
        public async Task DeveFazerLoginComSucesso()
        {
            Assert.That(_pagina.Url, Does.Contain("/dashboard/index"));
        }

        [Test, Order(2)]
        public async Task DashboardDeveCarregarCorretamente()
        {
            Assert.IsTrue(await _paginaDoDashboard.EstaNaPaginaAsync(), "Não está na página do dashboard");

            var titulo = await _paginaDoDashboard.ObterTituloAsync();
            Assert.IsTrue(titulo.Contains("Dashboard"), $"Título esperado 'Dashboard', mas foi '{titulo}'");

            Assert.IsTrue(await _paginaDoDashboard.PainelDeQuickLaunchVisivelAsync(), "Painel Quick Launch não está visível");

            // Extra (debug visual)
            await _pagina.ScreenshotAsync(new() { Path = "screenshot_dashboard.png" });
        }

        [OneTimeTearDown]
        public async Task CleanupGeral()
        {
            await _navegador.CloseAsync();
        }
    }
}
