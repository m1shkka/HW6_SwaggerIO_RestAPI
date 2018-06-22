using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace SwaggerIO
{
    [DataContract]
    public class Pet
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string category { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string photoURLs { get; set; }
        [DataMember]
        public string tags { get; set; }
        [DataMember]
        public string status { get; set; }

        public Pet(string Id, string Category, string Name, string Url, string Tags, string Status)
        {
            id = Id;
            category = Category;
            name = Name;
            photoURLs = Url;
            tags = Tags;
            status = Status;
        }

    }
    
}
