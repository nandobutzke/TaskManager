using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseTaskJson>
            {
                new ResponseTaskJson
                {
                    Id = 1,
                    Name = "Task 1",
                    Description = "Description 1",
                    Priority = TaskPriority.Low,
                    DateLimit = DateTime.Now,
                    Status = ProgressTaskStatus.InProgress
                },
                new ResponseTaskJson
                {
                    Id = 2,
                    Name = "Task 2",
                    Description = "Description 2",
                    Priority = TaskPriority.Medium,
                    DateLimit = DateTime.Now,
                    Status = ProgressTaskStatus.Waiting
                },
                new ResponseTaskJson
                {
                    Id = 3,
                    Name = "Task 3",
                    Description = "Description 3",
                    Priority = TaskPriority.High,
                    DateLimit = DateTime.Now,
                    Status = ProgressTaskStatus.Completed
                }
            }
        };
    }
}