using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterDtos
{
    public record BaseCenterDto(
        string Name,
        string Address
    );
}
