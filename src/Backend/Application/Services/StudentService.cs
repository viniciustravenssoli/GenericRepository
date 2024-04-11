using Application.DTOS;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;
public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<StudentDTO> Create(StudentDTO studentDTO)
    {
        var student = new Student
        {
            Name = studentDTO.Name,
            RGM = studentDTO.RGM,
        };

        await _studentRepository.Create(student);

        return studentDTO;
    }

    public async Task<StudentDTO> Get(long id)
    {
        var student = await _studentRepository.Get(id);

        var studentDTO = new StudentDTO
        {
            Name= student.Name,
            RGM = student.RGM,
        };

        return studentDTO;
        
    }

    public async Task<List<StudentDTO>> Get()
    {
        var students = await _studentRepository.Get();

        var studentDTOs = students.Select(student => new StudentDTO
        {
            Name = student.Name,
            RGM = student.RGM
        }).ToList();

        return studentDTOs;
    }

    public async Task<StudentDTO> GetStudentById(long studentId)
    {
        var student = await _studentRepository.Get(studentId);

        if (student is null)
        {
            throw new Exception("Nenhum estudante com esse Id foi encontrado");
        }

        var studentDTO = new StudentDTO
        {
            Name = student.Name,
            RGM = student.RGM,
        };

        return studentDTO;
    }

    public async Task Remove(long id)
    {
        await _studentRepository.Remove(id);
    }

    public async Task<StudentDTO> Update(StudentDTO studentDTO)
    {
        var studentExists = await _studentRepository.Get(studentDTO.Id);

        if (studentExists is null)
            throw new Exception("Nao existe nenhum estudante com o Id informado");

        var student = new Student
        {
            Name = studentDTO.Name,
            RGM= studentDTO.RGM,
        };

        var studentUpdated = await _studentRepository.Update(student);

        var studentUpdatedDTO = new StudentDTO
        {
            Name = studentUpdated.Name,
            RGM = studentUpdated.RGM,
        };

        return studentUpdatedDTO;
    }
}
