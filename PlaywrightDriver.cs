using Microsoft.Playwright;
using System.Threading.Tasks;

namespace OrangeHRM.Tests.Drivers;

public static class PlaywrightDriver
{
    public static async Task<IBrowser> GetBrowserAsync()
    {
        var playwright = await Playwright.CreateAsync();
        return await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false // true para rodar em modo invisível
        });
    }
}
