using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels;

public class CourseViewModel
{
    public IEnumerable<Course> Coursees { get; set; } = [];
}
