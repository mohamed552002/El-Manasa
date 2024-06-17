using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterDtos
{
    public record GetCenterDto:BaseCenterDto
    {
        public Guid Id { get; set; }
        public GetCenterDto(string name,string address):base(name,address) { }
    }
}
