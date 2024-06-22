using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CourseSectionDtos
{
    public record BaseCourseSectionDto(
        string Name, 
        string Description,
        DateTime StartDate,
        DateTime EndDate,
        bool IsActive
        );
}
