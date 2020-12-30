using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace JacksonVeroneze.ViaCepApi.Client
{
    public class HttpService : IHttpService
    {
        public Task<SearchDataResult> FindAsync(string value)
        {
            var gitHubApi = RestService.For<IHttpService>("https://viacep.com.br/");

            return gitHubApi.FindAsync(value);
        }

        public Task<IList<SearchDataResult>> FindCepsAsync(string state, string city, string street)
        {
	        var gitHubApi = RestService.For<IHttpService>("https://viacep.com.br/");

	        return gitHubApi.FindCepsAsync(state, city, street);
        }
    }
}
