namespace CinemaScheduleApp.Models;

public class Movie
{
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> ShowTimes { get; set; } = new();
}
