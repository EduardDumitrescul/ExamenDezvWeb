
using Examen.Data.Models;
using Repositories.TestRepository;

namespace Services.TestService;

public class TestService : ITestService
{
    private readonly ITestRepository _testRepository;

    public TestService(ITestRepository testRepository)
    {
        _testRepository = testRepository;
    }

    public async Task<List<Eveniment>> GetAll()
    {
        return await _testRepository.GetAllAsync();
    }

    public async Task Create(Eveniment test)
    {
        await _testRepository.CreateAsync(test);
        await _testRepository.SaveAsync();
    }

    public void Delete(Guid id)
    {
        _testRepository.DeleteById(id);
        _testRepository.SaveAsync();
    }

    public async Task Update(Eveniment test)
    {
        _testRepository.Update(test);
        await _testRepository.SaveAsync();
    }
}