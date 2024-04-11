using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;

namespace Infra.Repositories;
public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
