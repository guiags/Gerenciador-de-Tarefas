using Gerenciador_de_tarefas.Communication.Responses;

namespace Gerenciador_de_tarefas.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson> {
                new ResponseShortTaskJson {
                    Id = 1,
                    Name = "Alice",
                    Deadline = new DateOnly(2023,03,23)
                },
                new ResponseShortTaskJson {
                    Id = 2,
                    Name = "Lorde",
                    Deadline = new DateOnly(2023,09,15)
                }
            }
        };
    }
}
