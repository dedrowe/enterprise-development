using DistrictEnterpriseStatisticalData.Dto.DTO;

namespace DistrictEnterpriseStatisticalData.Client.Api;

public class ApiClientWrapper(IConfiguration configuration)
{
    private readonly Client _client = new(configuration["OpenApi:ServerUrl"], new HttpClient());

    public async Task<ICollection<EnterpriseDto>> GetAllEnterprises()
    {
        return await _client.EnterpriseAllAsync();
    }

    public async Task<EnterpriseDto> GetEnterprise(int id)
    {
        return await _client.EnterpriseGETAsync(id);
    }

    public async Task<EnterpriseDto> CreateEnterprise(EnterpriseCreateDto enterprise)
    {
        return await _client.EnterprisePOSTAsync(enterprise);
    }

    public async Task<EnterpriseDto> UpdateEnterprise(EnterpriseDto enterprise)
    {
        return await _client.EnterprisePUTAsync(enterprise);
    }

    public async Task DeleteEnterprise(int id)
    {
        await _client.EnterpriseDELETEAsync(id);
    }

    public async Task<EnterpriseTypeDto> GetEnterpriseType(int id)
    {
        return await _client.EnterpriseTypeGETAsync(id);
    }

    public async Task<FormOfOwnershipDto> GetFormOfOwnership(int id)
    {
        return await _client.FormOfOwnershipGETAsync(id);
    }
}