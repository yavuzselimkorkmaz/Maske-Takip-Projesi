    using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    //ciplak class kalmasın 
    public class PersonManager : IApplicantService 
    {
        //Encapsulation
        public void ApllyForMask(Person person) {
            
        }


        public List<Person> GetList() {
            return null;
        }

        //SOLID S : single resposibility bir sınıf sadece bir ozelligi tutar 

        public bool CheckPerson(Person person) {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;



        }
    }
}
