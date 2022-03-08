using System;

namespace learn.az.redis.cache.api
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Role Role { get; set; }


    }

    public enum Role
    {
        Unspecified,
        Director,
        Manager,
        Developer,
        QA,
        HR
    }
}
