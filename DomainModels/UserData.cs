using System;

namespace MovieSearchAPI.DomainModels
{
    public class UserData
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmailId { get; set; }
        public string UserPassword { get; set; }
    }
}
