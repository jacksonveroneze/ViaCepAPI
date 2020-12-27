using System.Threading.Tasks;
using Refit;

namespace JacksonVeroneze.ViaCepApi.Client
{
    public class HttpService : IHttpService
    {
        public Task<SearchDataResult> FindAsync(string value)
        {
            IHttpService gitHubApi = RestService.For<IHttpService>("https://viacep.com.br/");

            return gitHubApi.FindAsync(value);
        }
    }
}
