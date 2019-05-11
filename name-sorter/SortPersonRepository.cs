using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace name_sorter
{
    /// <summary>
    /// 'SortPersonRepository' Concrete class
    /// </summary>

    // SortPersonRepository implementing Interface 
    // ToDo: Easy implementation of Dependency Injection 
    public class SortPersonRepository : IPersonRepository
    {
        private Person _person; 
        
        //Default Constructor
        public SortPersonRepository() { }
               
        // Intitalize Person instance members 
        public SortPersonRepository(string [] bits)
        {
            _person = new Person()
            {
                FirstName = bits[0],
                MiddleName = bits.Length == 3 ? bits[1] : string.Empty,
                LastName = bits.Length >= 2 ? bits[bits.Length - 1] : string.Empty
            };
        }

        // Staic mehtod to sort List of Persons
        public static List<SortPersonRepository> SortPersonNames(List<SortPersonRepository> personNameList)
        {
            personNameList.Sort(delegate (SortPersonRepository firstPerson, SortPersonRepository secondPerson)
            {
                if ((firstPerson._person.LastName).ToLower() == secondPerson._person.LastName.ToLower())
                    return firstPerson._person.FirstName.CompareTo(secondPerson._person.FirstName);

                return firstPerson._person.LastName.CompareTo(secondPerson._person.LastName);
            });

            return personNameList;
        }
        
        // Override ToString method to return Person's Full Name
        public override string ToString()
        {
            return $"{_person.FirstName} {_person.MiddleName} {_person.LastName}".TrimEnd();
        }

        // Interface method implementation
        public string[] GetSplitPersonName(string fullName)
        {
            //Calling of Class Library function for NameSorter
            return NameSorter.Library.PeronName.SplitFullName(fullName);
                       
        }
    }
}
