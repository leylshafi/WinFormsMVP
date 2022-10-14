using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories;

public class EfStudentRepository : IStudentRepository
{
    public Student Get(Func<Student, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Student GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetList(Func<Student, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }



    public void Add(Student entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(Student entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Student entity)
    {
        throw new NotImplementedException();
    }
}
