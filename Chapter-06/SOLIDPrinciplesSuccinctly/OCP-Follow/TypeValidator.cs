namespace OCP_Follow
{
    public class TypeValidator : IValidator
    {
        public bool IsValid(ServerData data, SourceServerData sourceData)
        {
            return data.Type == sourceData.Type;
        }
    }
}
