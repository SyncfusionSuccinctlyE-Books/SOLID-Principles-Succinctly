using System.Collections.Generic;

namespace SRP_Follow
{
    public interface ITempStoreRepository
    {
        bool Store(InternalServerData data);
    }
}