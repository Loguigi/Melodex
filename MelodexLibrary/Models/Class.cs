namespace MelodexLibrary.Models;

public class Class
{
    public int Id { get; set; }
    public int ClassNum { get; set; }
    public int TreatmentPeriodId { get; set; }
    public TreatmentPeriod TreatmentPeriod { get; set; } = null!;
    public List<Student> Students { get; set; } = null!;
}