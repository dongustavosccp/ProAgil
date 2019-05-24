// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using ProAgil.Api.Data;
// using ProAgil.Api.Model;
// using ProAgil.Api.Model.Dto;

// namespace ProAgil.Api.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class ValuesController : ControllerBase
//     {
//         private readonly DataContext _context;

//         public ValuesController(DataContext context)
//         {
//             _context = context;
//         }

//         // GET api/values
//         [HttpGet]
//         public async Task<IActionResult> Get()
//         {
//             var result = StatusCode(StatusCodes.Status502BadGateway, "Deu Ruim antes de tudo"); ;

//             var lst = await _context.Eventos.ToListAsync();

//             try
//             {
//                 result = lst != null ? Ok(lst) : StatusCode(StatusCodes.Status500InternalServerError, new DtoError() { Id = StatusCodes.Status500InternalServerError, Descricao = "Não Encontrado" });
//             }
//             catch (System.Exception ex)
//             {

//                 result = StatusCode(StatusCodes.Status500InternalServerError, $"Deu Ruim, {ex.Message}");

//             }
//             return result;
//         }

//         // GET api/values/5
//         [HttpGet("{id}")]
//         public IActionResult Get(int id)
//         {
//             var result = StatusCode(StatusCodes.Status502BadGateway, "Deu Ruim antes de tudo"); ;

//             try
//             {
//                 var lst = _context.Eventos.FirstOrDefault(x => x.EventoId == id);

//                 result = lst != null ? Ok(lst) : StatusCode(StatusCodes.Status500InternalServerError, new DtoError() { Id = StatusCodes.Status500InternalServerError, Descricao = "Não Encontrado" });

//             }
//             catch (System.Exception ex)
//             {
//                 result = StatusCode(StatusCodes.Status500InternalServerError, $"Deu Ruim, {ex.Message}");

//             }

//             return result;
//         }

//         // POST api/values
//         [HttpPost]
//         public void Post([FromBody] string value)
//         {
//         }

//         // PUT api/values/5
//         [HttpPut("{id}")]
//         public void Put(int id, [FromBody] string value)
//         {
//         }

//         // DELETE api/values/5
//         [HttpDelete("{id}")]
//         public void Delete(int id)
//         {
//         }
//     }
// }
