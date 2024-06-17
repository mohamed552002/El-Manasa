using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterDtos
{
    public record UpdateCenterDto:BaseCenterDto
    {
        public UpdateCenterDto(string name,string address):base(name,address) { }
    }
}
