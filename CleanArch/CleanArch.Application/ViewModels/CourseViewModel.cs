using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels;

public class CourseViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public IEnumerable<Course> Coursees { get; set; } = [];
}
