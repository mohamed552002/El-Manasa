namespace FutureEducationalPlatform.Application.DTOS.ExamDtos
{
    public record BaseExamDto
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

