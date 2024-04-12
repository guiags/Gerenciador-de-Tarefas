using Gerenciador_de_tarefas.Communication.Requests;
using Gerenciador_de_tarefas.Communication.Responses;

namespace Gerenciador_de_tarefas.Application.UseCases.Tasks.Post;

public class PostTaskUseCase
{
    public string Execute(RequestTaskJson request)
    {
        string ret = $"A tarefa de Id {request.Id} foi criada com sucesso";
        return ret;
        
    }
}
