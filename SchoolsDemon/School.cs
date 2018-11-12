using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemon
{
    class School : IComparable
    {
        public string schoolName { get; }
        public int numOfStudents { get; set; }

        public School(string name, int number)
        {
            this.schoolName = name;
            this.numOfStudents = number;
        }

        public override string ToString()
        {
            return string.Format("\tName: {0}, students enrolled: {1}.", schoolName, numOfStudents);
        }
        public int CompareTo(object obj)
        {
            School other = (School)obj;

            if (this.numOfStudents > other.numOfStudents)
            {
                return 1;
            }else if(this.numOfStudents < other.numOfStudents)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
