using SupportExample.Models;

namespace SupportExample.Repositories;

public interface IProjectRepository
{
    Task<List<Project>> GetAllProjects();
}