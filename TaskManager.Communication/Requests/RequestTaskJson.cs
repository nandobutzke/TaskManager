using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public ProgressTaskStatus Status { get; set; }
}