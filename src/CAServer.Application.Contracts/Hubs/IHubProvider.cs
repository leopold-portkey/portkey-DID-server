using System.Threading.Tasks;

namespace CAServer.Hubs;

public interface IHubProvider
{
    Task ResponseAsync<T>(HubResponse<T> res, string clientId, string method, bool isFirstTime = true);
}