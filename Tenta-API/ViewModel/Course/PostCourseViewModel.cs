namespace Tenta_API.ViewModel.Course
{
  public class PostCourseViewModel
  {
    public int Number { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Details { get; set; }
    public bool IsVideo { get; set; }
    public int CategoryId { get; set; }
    public int LengthId { get; set; }
  }
}