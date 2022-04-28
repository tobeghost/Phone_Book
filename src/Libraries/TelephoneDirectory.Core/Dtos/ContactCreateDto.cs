using MongoDB.Bson.Serialization.Attributes;
using System;
using PhoneBook.Libraries.Core;

namespace PhoneBook.Libraries.Core
{
    public class ContactCreateDto
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    
    }
}
