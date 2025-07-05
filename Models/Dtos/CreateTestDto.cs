
namespace HealthCareDemo.Models.DTOs;

public class CreateTestDTO
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string Title { get; set; }
}