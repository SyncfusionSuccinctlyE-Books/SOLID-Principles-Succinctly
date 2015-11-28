namespace SRP
{
    public interface ISyncOperation
    {
        void Connect(string serverName);
        void Sync();
        bool Store();
        bool Save();
    }
}
