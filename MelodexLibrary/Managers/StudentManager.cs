using MelodexLibrary.Data;
using MelodexLibrary.Models;

namespace MelodexLibrary.Managers;

public class StudentManager(
    IDataRepository<Student> studentRepository)
{
    public async Task AddStudentToClass(Student student, Class @class)
    {
        student.Class = @class;
        await studentRepository.CreateAsync(student);
        @class.Students.Add(student);
    }
}