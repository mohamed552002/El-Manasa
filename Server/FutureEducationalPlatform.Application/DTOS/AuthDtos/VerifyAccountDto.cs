using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.AuthDtos
{
    public record VerifyAccountDto(
         string Email,
         string VerificationCode
        );
}
