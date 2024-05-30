using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    internal class TodoUpdateDto
    {
        public int Id { get; }
        public int? OwnerId { get; set; }
        public string? Title { get; set; }
        public bool? IsCompleted { get; set; }

        public TodoUpdateDto(int id)
        {
            Id = id;
        }
    }
}
