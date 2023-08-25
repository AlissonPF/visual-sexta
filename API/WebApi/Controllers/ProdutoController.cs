using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    private static List<Produto> produtos = new List<Produto>();
    // GET: 
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar() => produtos.Count == 0 ? NotFound() : Ok(produtos);
    // {
    //      if(produtos.Count == 0)
    //      {
    //          return NotFound();
    //      }
    //      return Ok(produtos);

    //      return produtos.Count == 0 ? NotFound() : Ok(produtos);
    // }

    [HttpGet]
    [Route("buscar/{nome}")]
    public IActionResult Buscar([FromRoute] string nome)
    {
        foreach(Produto produto in produtos)
        {
            if(produto.Nome == nome)
            {
                return Ok(produto);
            }
        }
        return NotFound();
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        produtos.Add(produto);
        return Created("", produto);
    }
}
