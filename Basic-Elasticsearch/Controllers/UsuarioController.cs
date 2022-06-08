using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Basic_Elasticsearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IElasticClient elasticClient;

        public UsuarioController(IElasticClient elasticClient)
        {
            this.elasticClient = elasticClient;
        }

        [HttpGet("{nome}")]
        public async Task<Usuario> GetUsuario(string nome)
        {
            var response = await elasticClient.SearchAsync<Usuario>(s => s
                .Index("usuarios")
                .Query(q => q.Match(m => m.Field(f => f.Nome).Query(nome))));

            return response.Documents.FirstOrDefault();
        }

        [HttpPost]
        public async Task<string> PostUsuario([FromBody] Usuario usuario)
        {
            var response = await elasticClient.IndexAsync<Usuario>(usuario, u => u.Index("usuarios"));
            return response.Id;
        }
    }
}
