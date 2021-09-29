using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    class User
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string DateOfBirth { get; set; }

        public User()
        {

        }
        public User(long id, string name, string emailId, string dateofbirth)
        {
            this.Id = id;
            this.Name = name;
            this.EmailId = emailId;
            this.DateOfBirth = dateofbirth;



        }

        public override string ToString()
        {
            return string.Format("Id:{0}\nName:{1}\nEmail Id:{2}\nDate of Birth:{3}", Id, Name, EmailId, DateOfBirth);
        }
    }
}
