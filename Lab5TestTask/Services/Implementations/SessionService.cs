using Lab5TestTask.Data;
using Lab5TestTask.Models;
using Lab5TestTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab5TestTask.Services.Implementations;

/// <summary>
//SessionService
/*
 //возвращает первую сессию рабочего стола

 public async Task<Session> GetSessionAsync()
{
return await _dbContext.Sessions.Where(s => s.Type == "Desktop").OrderBy(s => s.StartTime).FirstOrDefaultAsync();
}

//Возвращает сессии от активных пользователей, завершившихся до 2025 года

public async Task<List<Session>> GetSessionsAsync()
{
var currentYear = DateTime.Now.Year;
return await _dbContext.Sessions.Where(s => s.User.IsActive && s.EndTime < 2025).ToListAsync();
}

 */
/// </summary>
public class SessionService : ISessionService
{
    private readonly ApplicationDbContext _dbContext;

    public SessionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Session> GetSessionAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Session>> GetSessionsAsync()
    {
        throw new NotImplementedException();
    }
}
