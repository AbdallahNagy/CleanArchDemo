using CleanArch.Domain.Core.Commands;

namespace CleanArch.Domain.Commands;

public abstract class CourseCommand : Command
{
    public string Name { get; protected set; } = string.Empty;
    public string Description { get; protected set; } = string.Empty;
    public string ImageUrl { get; protected set; } = string.Empty;

}
