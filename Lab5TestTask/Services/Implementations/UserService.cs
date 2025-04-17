using Lab5TestTask.Data;
using Lab5TestTask.Models;
using Lab5TestTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab5TestTask.Services.Implementations;

/// <summary>
/*
 //возврат пользователя с наибольшим количеством сессий
 public async Task<User> GetUserAsync()
    {
        return await _dbContext.Users.OrderByDescending(u => u.Sessions.Count).FirstOrDefaultAsync();
    }

//возврат пользователей, у которых была хоть одна мобильная сессия
    public async Task<List<User>> GetUsersAsync()
    {
        return await _dbContext.Users.Where(u => u.Sessions.Any(s => s.Type == "Mobile")).ToListAsync();
    }
 */
/// </summary>
public class UserService : IUserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<User> GetUserAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}
