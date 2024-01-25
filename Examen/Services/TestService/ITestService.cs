
using Examen.Data.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Services.TestService;

public interface ITestService
{
    Task<List<Eveniment>> GetAll();
    Task Create(Eveniment test);
    void Delete(Guid id);
    Task Update(Eveniment test);
}