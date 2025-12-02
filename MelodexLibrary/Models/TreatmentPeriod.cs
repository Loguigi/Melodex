namespace MelodexLibrary.Models;

public class TreatmentPeriod
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int SchoolYearId { get; set; }
    public SchoolYear SchoolYear { get; set; } = null!;
    public List<Class> Classes { get; set; } = null!;
    public List<Session> Sessions { get; set; } = null!;
}