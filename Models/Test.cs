
namespace HealthCareDemo.Models;

public class Test
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string Title { get; set; }
}