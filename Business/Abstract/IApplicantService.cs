using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
