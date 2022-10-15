using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Contexts;

namespace WinFormsApp1.Repositories;

public class EfStudentRepository : IStudentRepository
{
    private readonly MyDBContext _context;
    public EfStudentRepository()
    {
        _context = new MyDBContext();
    }
    public Student? Get(Func<Student, bool> predicate)
    {
        return _context.Students.FirstOrDefault(predicate);
    }

    public Student? GetById(Guid Id)
    {
        return _context.Students.Find(Id);
    }

    public List<Student>? GetList(Func<Student, bool>? predicate = null)
    => (predicate == null) switch
    {
        true => _context.Students?.ToList(),
        false => _context.Students?.Where(predicate).ToList(),
    };



    public void Add(Student entity)
    {
        _context.Students?.Add(entity);
        _context.SaveChanges();
    }

    public void Remove(Student entity)
    {
        _context.Students?.Remove(entity);
        _context.SaveChanges();
    }

    public void Update(Student entity)
    {
        _context.Students?.Update(entity);
        _context.SaveChanges();
    }
}
