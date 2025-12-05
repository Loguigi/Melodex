using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MelodexLibrary.Models;

public class Session
{
    public int Id { get; set; }
    public int TreatmentPeriodId { get; set; }
    public TreatmentPeriod TreatmentPeriod { get; set; } = null!;
    [MaxLength(50)] public string Theme { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public List<Intervention> Interventions { get; set; } = null!;
    [NotMapped] public bool IsCurrentSession => Date == DateOnly.FromDateTime(DateTime.Now);
}