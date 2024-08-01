using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public IEnumerable<CourseViewModel> GetCourses()
    {
        var courses = _courseRepository.GetCourses();
        throw new NotImplementedException();
    }
}
