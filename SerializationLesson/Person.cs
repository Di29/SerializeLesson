using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace SerializationLesson
{
    //[Serializable]
    public class Person
    {
        [JsonProperty("fname")]
        public string FullNAme { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonIgnore]
        public bool Gender { get; set; }




    }
}
