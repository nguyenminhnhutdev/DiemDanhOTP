﻿namespace DiemDanhOTP.Core.Domain
{
    public class Teacher
    {
        public Teacher()
        {
            GroupSubjects = new HashSet<GroupSubject>();
        }

        public string Id { get; set; }
        public User IdUser { get; set; }

        public User User { get; set; }
        public virtual ICollection<GroupSubject> GroupSubjects { get; set; }
    }
}
