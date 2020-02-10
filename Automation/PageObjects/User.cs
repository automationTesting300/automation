using System.Collections.Generic;
using Bogus;

namespace AutomationFramework.PageObjects
{
    public class User
    {
        public object mobile;
        public object Phone { get; internal set; }
        public object FirstName { get; internal set; }
        public object LastName { get; internal set; }
        public object Title { get; internal set; }
        public object Suffix { get; internal set; }
        public object EmailAddress { get; internal set; }
        public object Street { get; internal set; }
        public object City { get; internal set; }
        public object Zip { get; internal set; }


        // creates the fake data for a user
        public static List<User> GetSampleTableData()
        {

            var userFaker = new Faker<User>()
                    .CustomInstantiator(f => new User())
                    .RuleFor(o => o.Phone, f => f.Phone.PhoneNumber())
                    .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                    .RuleFor(o => o.LastName, f => f.Name.LastName())
                    .RuleFor(o => o.Title, f => f.Name.Prefix(f.Person.Gender)).RuleFor(o => o.Suffix, f => f.Name.Suffix())
                    .RuleFor(o => o.Street, f => f.Address.StreetAddress())
                    .RuleFor(o => o.City, f => f.Address.City())
                    .RuleFor(o => o.Zip, f => f.Address.ZipCode())
                    .RuleFor(o => o.mobile, f => f.Phone.PhoneNumber())
                    .RuleFor(o => o.EmailAddress, (f, u) => f.Internet.Email((string)u.FirstName, (string)u.LastName, "e.co.uk", "a"));

            var users = userFaker.Generate(1000);
            return users;
        }
    }
}