using CityDiscoverTourist.Business.Data.RequestModel;
using CityDiscoverTourist.Business.Data.ResponseModel;
using CityDiscoverTourist.Business.Helper;
using CityDiscoverTourist.Business.Helper.Params;

namespace CityDiscoverTourist.Business.IServices;

public interface IQuestService
{
    public PageList<Entity> GetAll(QuestParams param);
    public Task<QuestResponseModel> Get(Guid id, string? fields);
    public Task<QuestResponseModel> CreateAsync(QuestRequestModel request);
    public Task<QuestResponseModel> UpdateAsync(QuestRequestModel request);
    public Task<QuestResponseModel> DeleteAsync(Guid questId);
}