namespace OCP_Follow
{
    public interface IValidateData
    {
        bool Validate(ServerData data, SourceServerData sourceData);
    }
}