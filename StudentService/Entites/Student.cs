using Microsoft.AspNetCore.Http.HttpResults;
using System.Xml.Linq;

namespace StudentService.Entites
{
    //CREATE TABLE Student(
    //id INT NOT NULL,
    //name VARCHAR(100),
    //email VARCHAR(50),
    //join_date DATE,
    //PRIMARY KEY(id)

    public class Student
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime join_date { get; set; }
    }
}
