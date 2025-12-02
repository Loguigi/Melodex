using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class Session
{
    public int Id { get; set; }
    [MaxLength(50)] public string Theme { get; set; } = string.Empty;
    public int TreatmentPeriodId { get; set; }
    public TreatmentPeriod TreatmentPeriod { get; set; } = null!;
    public List<Intervention> Interventions { get; set; } = null!;
}