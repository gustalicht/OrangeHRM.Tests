using Microsoft.Playwright;
using System.Threading.Tasks;

namespace OrangeHRM.Tests.Pages;

public class PaginaDeLogin
{
    private readonly IPage _pagina;

    public PaginaDeLogin(IPage pagina)
    {
        _pagina = pagina;
    }

    public async Task AcessarPaginaAsync()
    {
        await _pagina.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    }

    public async Task PreencherUsuario(string usuario)
    {
        await _pagina.FillAsync("input[name='username']", usuario);
    }

    public async Task PreencherSenha(string senha)
    {
        await _pagina.FillAsync("input[name='password']", senha);
    }

    public async Task ClicarEmEntrar()
    {
        await _pagina.ClickAsync("button[type='submit']");
    }

    public async Task<bool> DashboardVisivel()
    {
        return await _pagina.Locator("text=Dashboard").IsVisibleAsync();
    }

    public string ObterUrlAtual()
    {
        return _pagina.Url;
    }
}
