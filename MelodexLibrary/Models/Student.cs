using System.ComponentModel.DataAnnotations;

namespace MelodexLibrary.Models;

public class Student
{
    public int Id { get; set; }
    [MaxLength(25)] public string Name { get; set; } = string.Empty;
    public int ClassId { get; set; }
    public Class Class { get; set; } = null!;
    public List<Intervention> Interventions { get; set; } = null!;
}