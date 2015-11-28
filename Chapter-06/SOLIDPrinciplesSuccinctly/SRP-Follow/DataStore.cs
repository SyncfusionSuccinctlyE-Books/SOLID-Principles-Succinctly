using System.Collections.Generic;

namespace SRP_Follow
{
    /// <summary>
    /// Store data in temporary storage
    /// </summary>
    public class DataStore
    {
        private ITempStoreRepository _repository;
        public DataStore(ITempStoreRepository repository)
        {
            _repository = repository;
        }

        public bool Store(IEnumerable<ExternalServerData> data)
        {
            bool isSuccess=false;
            foreach (var d in data)
            {
                //make some logging so, we can know about failures
                isSuccess =  _repository.Store(ToInternalServerData(d));
            }
           
            return isSuccess;
        }

       
        private InternalServerData ToInternalServerData(ExternalServerData data)
        {
            //logic to exchange data 
            return new InternalServerData();
        }
    }
}
