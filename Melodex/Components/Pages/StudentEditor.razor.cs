using MelodexLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace Melodex.Components.Pages;

public partial class StudentEditor : ComponentBase
{
    [Parameter] public int CurrentTreatmentPeriodId { get; set; }
    [Parameter] public int ClassId { get; set; }
}