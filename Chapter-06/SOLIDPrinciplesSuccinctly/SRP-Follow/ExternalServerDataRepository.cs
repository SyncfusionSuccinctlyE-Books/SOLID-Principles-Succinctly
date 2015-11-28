using System;
using System.Collections.Generic;

namespace SRP_Follow
{
    public class ExternalServerDataRepository : IExternalServerDataRepository
    {
        private readonly List<ExternalServerData> _dataList = GetServerData();

        public IEnumerable<ExternalServerData> Sync()
        {
            return _dataList;
        }

        //This is a sample data
        private static List<ExternalServerData> GetServerData()
        {
            return new List<ExternalServerData>(new[]
            {
                new ExternalServerData
                {
                    Id = 1,
                    InitialDate= new DateTime(2014,01,01),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=1,
                    IsDirty=false,
                    Type = 1,
                    IP ="127.0.0.1"
                },

                new ExternalServerData
                {
                    Id = 2,
                    InitialDate= new DateTime(2014,01,15),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=2,
                    IsDirty=true,
                    Type=1,
                    IP ="127.0.0.1"
                }
            });
        }
    }
}
