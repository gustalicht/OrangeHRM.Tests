using Microsoft.Playwright;
using System.Threading.Tasks;

namespace OrangeHRM.Tests.Pages
{
    public class PaginaDoDashboard
    {
        private readonly IPage _pagina;

        public PaginaDoDashboard(IPage pagina)
        {
            _pagina = pagina;
        }

        public async Task<bool> EstaNaPaginaAsync()
        {
            return _pagina.Url.Contains("/dashboard/index");
        }

        public async Task<string> ObterTituloAsync()
        {
            return await _pagina.TextContentAsync("h6.oxd-text--h6");
        }

        public async Task<bool> PainelDeQuickLaunchVisivelAsync()
        {
            try
            {
                var seletor = "div[class*='quick-launch']";
                var elemento = await _pagina.WaitForSelectorAsync(seletor, new()
                {
                    State = WaitForSelectorState.Visible,
                    Timeout = 5000
                });

                return elemento != null && await elemento.IsVisibleAsync();
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Timeout esperando pelo painel de Quick Launch");
                return false;
            }
        }
    }
}
