namespace SRP
{
    public class SyncOperation : ISyncOperation
    {
        public void Connect(string serverName)
        {
            //TODo - logic to connect external Dataabse
            //Refer http://www.connectionstrings.com/
        }

        public bool Save()
        {
            //Permanently persist data from temporary storage
            //this is final operation

            return true;
        }

        public bool Store()
        {
            //Store synced data in temprary storage
            return true;
        }

        public void Sync()
        {
            //Start syncing external data
        }
    }
}
