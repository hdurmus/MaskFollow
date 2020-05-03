using Entities;
using MernisServiceReference;
using System.Collections.Generic;

namespace Business
{
    public class PersonManager : IApplicantService
    {

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName, Soyad: person.LastName, DogumYili: person.DateOfBirthYear)
                )).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
