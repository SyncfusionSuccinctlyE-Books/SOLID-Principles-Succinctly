namespace OCP_Follow
{
    public class IPValidator : IValidator
    {
        public bool IsValid(ServerData data, SourceServerData sourceData)
        {
            return data.IP != sourceData.IP;
        }
    }
}
