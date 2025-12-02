namespace MelodexLibrary.Models;

public class SchoolYear
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}