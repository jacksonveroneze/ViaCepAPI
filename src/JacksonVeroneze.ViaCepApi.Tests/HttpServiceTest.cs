using System.Threading.Tasks;
using FluentAssertions;
using JacksonVeroneze.ViaCepApi.Client;
using Xunit;

namespace JacksonVeroneze.ViaCepApi.Tests
{
    public class HttpServiceTest
    {
        [Fact]
        public async Task HttpService_Find_DeveBuscarCorretamente()
        {
            // Arange
            IHttpService service = new HttpService();

            // Act
            SearchDataResult result = await service.FindAsync("89665000");

            // Assert
            result.Should().NotBeNull();
            result.Uf.Should().Be("SC");
            result.Localidade.Should().Be("Capinzal");
            result.Ibge.Should().Be(4203907);
        }
    }
}
