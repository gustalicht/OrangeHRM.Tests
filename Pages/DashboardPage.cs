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
            // Verifica se a URL atual contém "/dashboard/index"
            return _pagina.Url.Contains("/dashboard/index");
        }

        public async Task<string> ObterTituloAsync()
        {
            // Pega o texto do título do dashboard (ajuste o seletor se precisar)
            return await _pagina.TextContentAsync("h6.oxd-text--h6");
        }

        public async Task<bool> PainelDeQuickLaunchVisivelAsync()
        {
            // Verifica se o painel quick launch está visível
            return await _pagina.IsVisibleAsync("div.orangehrm-quick-launch-panel");
        }

        // Aqui pode adicionar outros métodos pra validar elementos do dashboard
    }
}
