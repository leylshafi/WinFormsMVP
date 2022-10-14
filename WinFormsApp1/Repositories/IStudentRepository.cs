using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories;

public interface IStudentRepository:IRepository<Student>
{
    Student GetById(Guid Id);
}
