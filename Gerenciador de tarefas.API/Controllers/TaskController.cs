using Gerenciador_de_tarefas.Application.UseCases.Tasks.GetAll;
using Gerenciador_de_tarefas.Communication.Requests;
using Gerenciador_de_tarefas.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_tarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById(int id) //Deve ser possível visualizar uma tarefa buscando pelo seu id;
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }
}
