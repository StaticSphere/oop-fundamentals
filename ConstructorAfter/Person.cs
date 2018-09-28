using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConstructorAfter
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName ?? ""} {LastName ?? ""} has Id = {Id}";
        }

        public Person()
        {
        }

        // By moving the file initilization into its own method, we free
        // the constructor to be responsible for JUST creating the class.
        // This allows us to create the object, and interact with it. If
        // it has methods that don't rely on the loaded file, then we can
        // forego loading the file.
        public void InitializeFromFile()
        {
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