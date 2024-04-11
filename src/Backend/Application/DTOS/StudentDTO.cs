using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS;
public class StudentDTO
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string RGM { get; set; } = string.Empty;
}
