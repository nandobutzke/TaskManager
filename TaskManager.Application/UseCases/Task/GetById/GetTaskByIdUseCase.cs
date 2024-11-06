using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Task 1",
            Description = "Description 1",
            Priority = TaskPriority.Low,
            DateLimit = DateTime.Now,
            Status = ProgressTaskStatus.InProgress
        };
    }
}