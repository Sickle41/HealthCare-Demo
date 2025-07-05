
namespace HealthCareDemo.Models;

public class Video
{
    public int Id { get; set; }
    public int? courseId { get; set; }
    public Course Course { get; set; }
    public string FilePath { get; set; }
    public long FileSize { get; set; }
    public string MimeType { get; set; }
    public TimeSpan Duration { get; set; }
    public int OrderInCourse { get; set; }

}