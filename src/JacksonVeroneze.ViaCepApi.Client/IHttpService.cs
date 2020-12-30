using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace JacksonVeroneze.ViaCepApi.Client
{
    [Headers("Accept: application/json;charset=UTF-8")]
    public interface IHttpService
    {
        [Get("/ws/{value}/json/")]
        Task<SearchDataResult> FindAsync(string value);

        [Get("/ws/{state}/{city}/{street}/json/")]
        Task<IList<SearchDataResult>> FindCepsAsync(string state, string city, string street);
    }
}
