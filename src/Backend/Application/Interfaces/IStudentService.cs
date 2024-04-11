using Application.DTOS;

namespace Application.Interfaces;
public interface IStudentService
{
    Task<StudentDTO> Create(StudentDTO studentDTO);
    Task<StudentDTO> Update(StudentDTO studentDTO);
    Task<StudentDTO> GetStudentById(long studentId);
    Task Remove(long id);
    Task<StudentDTO> Get(long id);
    Task<List<StudentDTO>> Get();
}
