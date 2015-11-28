using System.Collections.Generic;

namespace SRP_Follow
{
    /// <summary>
    /// This class should be and only responsible for sync operation
    /// </summary>
    public class SyncOperation
    {
        private IList<ExternalServerData> _data;
        private DataStore _dataStore;
        private DatabaseServer _dbServer;
        private IExternalServerDataRepository _repository;

        public SyncOperation(IList<ExternalServerData> data, IExternalServerDataRepository repository, DatabaseServer dbServer)
        {
            _data = data;
            _repository = repository;
            _dbServer = dbServer;
            _dataStore = new DataStore(new TempStoreRepository());
        }

        public void Sync()
        {
            //Start syncing of data as per requested server
            _dataStore.Store(_repository.Sync());

        }
    }
}
