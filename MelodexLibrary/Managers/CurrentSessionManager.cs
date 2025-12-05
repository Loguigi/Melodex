using MelodexLibrary.Data;
using MelodexLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MelodexLibrary.Managers;

public class CurrentSessionManager(
    IDataRepository<Session> sessionRepository,
    IDataRepository<Intervention> interventionRepository,
    IDataRepository<StudentInterventionResponse> studentInterventionResponseRepository,
    ILogger<CurrentSessionManager> logger)
{
    public async Task<Session?> GetCurrentSessionAsync()
    {
        var sessions = await sessionRepository.GetFilteredAsync(
            filter: q => q.Where(session => session.Date == DateOnly.FromDateTime(DateTime.Now)),
            includes: q => q
                .Include(s => s.TreatmentPeriod)
                    .ThenInclude(tp => tp.Classes)
                        .ThenInclude(c => c.Students)
                .Include(s => s.TreatmentPeriod)
                    .ThenInclude(tp => tp.SchoolYear)
                .Include(s => s.Interventions)
                    .ThenInclude(i => i.Class)
                .Include(s => s.Interventions)
                    .ThenInclude(i => i.Responses)
                        .ThenInclude(ri => ri.Student));

        return sessions.FirstOrDefault();
    }

    public async Task StartSession(Session session)
    {
        await sessionRepository.CreateAsync(session);
    }

    public async Task AddIntervention(Intervention intervention, Class currentClass)
    {
        intervention.Class = currentClass;

        var responses = currentClass.Students.Select(student => 
            new StudentInterventionResponse 
            { 
                Intervention = intervention, 
                Student = student 
            }).ToList();

        intervention.Responses = responses;

        await interventionRepository.CreateAsync(intervention);
    }
    
    public async Task UpdateInterventionResponse(StudentInterventionResponse response)
    {
        await studentInterventionResponseRepository.UpdateAsync(response);
    }
}