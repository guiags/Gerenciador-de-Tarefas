using Gerenciador_de_tarefas.Communication.Requests;

namespace Gerenciador_de_tarefas.Application.UseCases.Tasks.Put;

public class PutTaskById
{
    public string Execute(int id, RequestTaskJson request)
    {
        //Somente realiza a alteração e retorna o que foi alteado
        string ret = $"A tarefa de Id {id} foi alterada com sucesso";
        return ret;
    }
}
