using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mac_app.Pages
{
    public class IndexModel : PageModel
    {
        private const string RequestUri = "https://localhost/api/members";
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Member> Members { get; private set; }

        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public void OnGet()
        {
            // var client = _clientFactory.CreateClient();
            // var request = new HttpRequestMessage(HttpMethod.Get,
            //     RequestUri);
            //     request.Headers.Add("Accept", "application/vnd.github.v3+json");
            //     request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            // var response = await client.SendAsync(request);

            // if (response.IsSuccessStatusCode)
            // {
            //     Members = await response.Content
            //         .ReadAsAsync<IEnumerable<Member>>();
            // }
            // else
            // {
            //     Members = Array.Empty<Member>();
            // }
        }
    }
}
