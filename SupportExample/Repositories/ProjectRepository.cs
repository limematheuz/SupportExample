using Microsoft.EntityFrameworkCore;
using SupportExample.Data;
using SupportExample.Models;

namespace SupportExample.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDbContext _context;

    public ProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Project>> GetAllProjects()
    {
        return await _context.Projects.ToListAsync();
    }
}