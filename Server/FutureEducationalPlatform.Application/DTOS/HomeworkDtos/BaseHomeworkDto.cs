﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.HomeworkDtos
{
    public record BaseHomeworkDto
    {
        public string Name;
        public bool IsActive = true;
    }
}