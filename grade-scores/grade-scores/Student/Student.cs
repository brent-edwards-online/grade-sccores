using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores.Student
{
    public class Student : IStudent
    {
        private Student() { }
        private Student(string firstname, string lastname, UInt16 score) {
            _firstname = firstname;
            _lastname = lastname;
            _score = score;
        }

        public static Student Create(string firstname, string lastname, UInt16 score)
        {
            if (firstname == null || firstname.Length == 0)
                return null;
            if (lastname == null || lastname.Length == 0)
                return null;
            if (score > 100)
                return null;
            return new Student(firstname, lastname, score);
        }

        private string _firstname;
        private string _lastname;
        private UInt16 _score;

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_lastname);
            builder.Append(", ");
            builder.Append(_firstname);
            builder.Append(", ");
            builder.Append(_score);
            return builder.ToString();
        }
    }
}
