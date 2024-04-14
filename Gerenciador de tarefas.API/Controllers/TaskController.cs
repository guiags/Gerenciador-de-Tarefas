using Gerenciador_de_tarefas.Application.UseCases.Tasks.Delete;
using Gerenciador_de_tarefas.Application.UseCases.Tasks.GetAll;
using Gerenciador_de_tarefas.Application.UseCases.Tasks.Post;
using Gerenciador_de_tarefas.Application.UseCases.Tasks.Put;
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


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var usecase = new GetAllTasksUseCase(); // Deve ser possível visualizar todas as tarefas criadas;
        var response = usecase.Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult PostTask([FromBody]RequestTaskJson request)//Deve ser possível criar uma tarefa;
    {
        var useCase = new PostTaskUseCase();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }


    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)//Deve ser possível excluir uma tarefa.
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }

    [HttpPut]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult UpdateById(int id, RequestTaskJson request)
    {
        var useCase = new PutTaskById();
        var ret = useCase.Execute(id, request);
        return Ok(ret);
    }

}
