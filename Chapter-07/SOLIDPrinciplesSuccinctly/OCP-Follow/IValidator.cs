namespace OCP_Follow
{
    public interface IValidator
    {
        bool IsValid(ServerData data, SourceServerData sourceData);
    }
}
