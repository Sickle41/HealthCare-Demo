
namespace HealthCareDemo.Models.DTOs;

public class CreateVideoDTO
{
    public int CourseId { get; set; }

    public string Title { get; set; }

    // This will typically be a file upload
    public IFormFile File { get; set; }

    public int OrderInCourse { get; set; }
}
