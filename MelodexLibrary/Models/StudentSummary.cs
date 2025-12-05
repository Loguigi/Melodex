using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class StudentSummary
{
    public int Id { get; set; }
    public int TreatmentPeriodId { get; set; }
    public TreatmentPeriod TreatmentPeriod { get; set; } = null!;
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    [MaxLength(2000)] public string Summary { get; set; } = null!;
}