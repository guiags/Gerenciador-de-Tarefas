using Gerenciador_de_tarefas.Communication.enums;

namespace Gerenciador_de_tarefas.Communication.Responses;

public class ResponseTaskJson { 

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateOnly Deadline { get; set; }
    public Status status { get; set; }
}
