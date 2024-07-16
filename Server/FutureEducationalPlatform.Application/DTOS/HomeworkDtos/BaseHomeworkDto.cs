namespace FutureEducationalPlatform.Application.DTOS.HomeworkDtos
{
    public record BaseHomeworkDto
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
