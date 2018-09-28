using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConstructorBefore
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} has Id = {Id}";
        }

        public Person()
        {
            // By initialize the state of this class, from within the
            // constructor via loading a file, we ensure that we cannot
            // ever create an instance of this class WITHOUT reading the
            // file. If the file load fails (it doesn't exist, it's locked,
            // etc.), the creation of the object fails.
            string json = null;
            using (var reader = new StreamReader("Person.json"))
                json = reader.ReadToEnd();

            dynamic person = JObject.Parse(json);
            this.Id = person.Id;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
        }
    }
}