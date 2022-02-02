using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApressMvc.Components
{
    public class PageSize : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://google.com");

            return View(response.Content.Headers.ContentLength);
        }
    }
}
