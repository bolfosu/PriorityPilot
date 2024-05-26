using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogicInterfaces
{
    internal interface ITodoLogic
    {
        Task<Todo> CreateAsync(TodoCreationDto dto);
    }
}
