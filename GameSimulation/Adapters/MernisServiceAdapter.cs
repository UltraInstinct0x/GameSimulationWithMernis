using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameSimulation.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcId),
                                                 gamer.FirstName.ToUpper(),
                                                 gamer.LastName.ToUpper(),
                                                 gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
