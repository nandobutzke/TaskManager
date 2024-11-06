using TaskManager.Communication.Enums;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;
public class CreateTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskJson
        {
            Id = 7,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DateLimit = request.DateLimit,
            Status = request.Status
        };
    }
}