using System;
namespace dotnetWeb.Models
{
    public class Teacher
    {

        public int Id
        {
            get;
        }

        public string Name
        {
            get;
            set;
        }

        public int ClassId
        {
            get;
            set;
        }

    //constructor
    public Teacher(int id, string name, int classId)
    {
        Id = id;
        Name = name;
        ClassId = classId;
    }
}
}
