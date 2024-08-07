﻿using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }
        public async Task<User> GetUserByRefreshTokenAsync(string refreshToken)
        {
            var user =await _context.Users.Include(u => u.RefreshTokens).FirstOrDefaultAsync(u => u.RefreshTokens.Any(r => r.Token == refreshToken));
            return user;
        }
    }
}
