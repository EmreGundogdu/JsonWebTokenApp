using JsonWebToken.Front.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace JsonWebToken.Front.Controllers
{
    public class CategoryController : Controller
    {
        readonly IHttpClientFactory httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> List()
        {
            var client = this.httpClientFactory.CreateClient();
            var token = User.Claims.SingleOrDefault(x => x.Type == "accesstoken")?.Value;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync("http://localhost:5186/api/categories");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var list = JsonSerializer.Deserialize<List<CategoryListResponseModel>>(jsonString, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                });
                return View(list);
            }
            //else if(response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            //{
            //    return RedirectToAction("AccessDenied", "Account");
            //}
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
