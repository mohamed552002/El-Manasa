using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CourseSectionDtos
{
    public record UpdateCourseSectionDto : BaseCourseSectionDto
    {
        public UpdateCourseSectionDto(string Name, string Description, DateTime StartDate, DateTime EndDate, bool IsActive) : base(Name, Description, StartDate, EndDate, IsActive)
        {
        }
    }
}
