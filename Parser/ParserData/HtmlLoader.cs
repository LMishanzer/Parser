using System.Net.Http;
using System.Threading.Tasks;
using Parser.Interfaces;

namespace Parser.Classes
{
    class HtmlLoader
    {
        private readonly HttpClient client;
        private readonly string url;

        public HtmlLoader(IParserConfig config)
        {
            client = new HttpClient();
            url = $"{config.Url}/{config.Prefix}";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url + id + "/";
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.IsSuccessStatusCode)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
