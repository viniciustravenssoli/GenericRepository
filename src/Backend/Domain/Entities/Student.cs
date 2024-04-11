using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Student : Base
{
    public string Name { get; set; } = string.Empty;
    public string RGM { get; set; } = string.Empty;
}
