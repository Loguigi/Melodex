using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class Intervention
{
    public int Id { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; } = null!;
    public int ClassId { get; set; }
    public Class Class { get; set; } = null!;
    public InterventionType InterventionType { get; set; }
    [MaxLength(50)] public string Description { get; set; } = string.Empty;
    public List<StudentInterventionResponse> Responses { get; set; } = [];
}