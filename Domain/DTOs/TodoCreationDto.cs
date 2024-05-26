using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    internal class TodoCreationDto
    {
        public int OwnerId { get; }
        public string Title { get; }

        public TodoCreationDto(int ownerId, string title)
        {
            OwnerId = ownerId;
            Title = title;
        }
    }
}
