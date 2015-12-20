using System.Collections.Generic;

namespace SRP_Follow
{
    public interface IExternalServerDataRepository
    {
        IEnumerable<ExternalServerData> Sync();
    }
}