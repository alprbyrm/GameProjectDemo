using GameProjectDemo.Abstract;
using MerbisServiceReference;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapter
{
    class MernisServisAdapter : IGamerCheckManager
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(gamer.NationalityNumber),
                    gamer.FirstName.ToUpper(),
                    gamer.LastName.ToUpper(),
                    Convert.ToInt32(gamer.DateOfBirth.Year))))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
