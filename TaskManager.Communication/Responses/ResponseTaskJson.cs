using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public ProgressTaskStatus Status { get; set; } = ProgressTaskStatus.Waiting;
}