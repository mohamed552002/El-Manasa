using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CourseSectionDtos
{
    public record CreateCourseSectionDto : BaseCourseSectionDto
    {
        public CreateCourseSectionDto(string Name, string Description, DateTime StartDate, DateTime EndDate,Guid CourseId, bool IsActive=true) : base(Name, Description, StartDate, EndDate,CourseId,IsActive)
        {
        }
    }
}
