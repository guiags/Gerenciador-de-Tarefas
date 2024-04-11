using System.Globalization;

namespace Gerenciador_de_tarefas.Communication.Responses;

public class ResponseErrorsJson
{
    public List<StringInfo> Errors { get; set; } = [];
}
