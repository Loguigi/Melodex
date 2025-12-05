using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class StudentInterventionResponse
{
    public int Id { get; set; }
    public int InterventionId { get; set; }
    public Intervention Intervention { get; set; } = null!;
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public ResponseType Response { get; set; } = ResponseType.NotAvailable;
    [MaxLength(500)] public string Notes { get; set; } = string.Empty;
}