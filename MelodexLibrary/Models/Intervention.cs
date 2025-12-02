using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class Intervention
{
    public int Id { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; } = null!;
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public InterventionType InterventionType { get; set; }
    public ResponseType ResponseType { get; set; }
    [MaxLength(500)] public string Notes { get; set; } = string.Empty;
}