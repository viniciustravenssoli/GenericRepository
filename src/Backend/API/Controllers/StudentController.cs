using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Responses;
using Application.DTOS;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [Route("/api/v1/student/create")]
        public async Task<IActionResult> Create([FromBody] StudentDTO studentDTO)
        {
            try
            {
                var studentCreated = await _studentService.Create(studentDTO);

                return Ok(new ResultViewModel
                {
                    Message = "Aluno criado com sucesso",
                    Success = true,
                    Data = studentCreated
                });
            }
            catch (Exception)
            {
                return StatusCode(500, string.Empty);
            }
        }

        [HttpPut]
        [Route("/api/v1/student/update")]
        public async Task<IActionResult> Update([FromBody] StudentDTO studentDTO)
        {
            try
            {
                var stundetUpdated = await _studentService.Update(studentDTO);

                return Ok(new ResultViewModel
                {
                    Message = "Aluno atualizado com sucesso",
                    Success = true,
                    Data = stundetUpdated
                });
            }

            catch (Exception)
            {
                return StatusCode(500, string.Empty);
            }
        }

        [HttpGet]
        [Route("/api/v1/student/get-all")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var students = await _studentService.Get();

                return Ok(new ResultViewModel
                {
                    Message = "Alunos retornados com sucesso",
                    Success = true,
                    Data = students
                });
            }
            catch (Exception)
            {
                return StatusCode(500, string.Empty);
            }
        }

        [HttpGet]
        [Route("/api/v1/student/get/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var student = await _studentService.Get(id);

                return Ok(new ResultViewModel
                {
                    Message = "Aluno retornado com sucesso",
                    Success = true,
                    Data = student
                });
            }
            catch (Exception)
            {
                return StatusCode(500, string.Empty);
            }
        }
    }
}