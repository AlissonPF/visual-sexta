using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    // GET: api/produto/listar
    [HttpGet]
    [Route("listar")]
    public string Listar()
    {
        return "Hello World de uma API em C# com Watch";
    }

    [HttpPost]
    [Route("cadastrar")]
    public Produto Cadastrar(Produto produto)
    {
        return produto;
    }
}
