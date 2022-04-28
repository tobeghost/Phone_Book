using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PhoneBook.Libraries.Core
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }
}
