using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebIPS.Clients.Base
{
    public abstract class BaseClient
    {
        protected string Address { get; }

        protected HttpClient Http { get; }

        public BaseClient(IConfiguration Configuration, string ServiceAddress)
        {
            Address = ServiceAddress;

            Http = new HttpClient
            {
                BaseAddress = new Uri(Configuration["WebIPS.Service.URL"]),
                DefaultRequestHeaders =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json") }
                }
            };
        }
    }
}
