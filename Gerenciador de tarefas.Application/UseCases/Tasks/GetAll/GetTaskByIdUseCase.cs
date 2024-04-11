using Gerenciador_de_tarefas.Communication.Responses;

namespace Gerenciador_de_tarefas.Application.UseCases.Tasks.GetAll;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson {
            Id = id,
            Name = "Alice",
            Priority = Communication.enums.Priority.Média,
            status = Communication.enums.Status.Em_Andamento,
            Description = "Top",
            Deadline = new DateOnly(year: 2023, month: 01, day: 29)
        };

    }
}
