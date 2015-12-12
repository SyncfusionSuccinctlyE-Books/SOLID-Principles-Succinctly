namespace OCP_Violation
{
    public class ValidateData
    {
        public void SyncronizeData(ServerData data, SourceServerData sourceData)
        {
            if (IsValid(data, sourceData))
            {
                //First validate data and then send to persist
            }
        }

        private bool IsValid(ServerData data, SourceServerData sourceData)
        {
            var result = false;
            if (data.Type == sourceData.Type)
                result = true;
            if (data.IP != sourceData.IP)
                result = true;
            //other checks/rules to validate incoming data
            return result;
        }
    }
}
