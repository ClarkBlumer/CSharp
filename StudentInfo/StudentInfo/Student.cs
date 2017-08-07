using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Student
    {
        string m_firstName;
        string m_lastName;
        int m_studentID;
        double m_GPA;

        public Student() : this("John", "Doe", 0000, 0.0)
        {

        }

        public Student(string firstName, string lastName, int studentID, double GPA)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.GPA = GPA;
            this.studentID = studentID;

        }

        /// <summary>
        /// Getter/Setter for m_GPA
        /// Checks to see if the passed value is between 0.0 and 4.0. If the value
        /// is not in the range, then a default of 0.0 is assigned.
        /// </summary>
        public double GPA
        {
            get
            {
                return m_GPA;
            }
            set
            {
                if (value < 0.0f || value > 4.0f)
                {
                    m_GPA = 0.0f;
                }
                else
                {
                    m_GPA = value;
                }
            }
        }

        /// <summary>
        /// Getter/Setter for m_studentID
        /// checks if the value is a 4 digit integer, if the value is not 4 digits, it assigns a 
        /// default value of 0000
        /// </summary>
        public int studentID
        {
            get
            {
                return m_studentID;
            }
            set
            {
                if (value > 9999 || value < 0)
                {
                    m_studentID = 0000;
                }
                else
                {
                    m_studentID = value;
                }
            }
        }

        /// <summary>
        /// Getter/Setter for m_firstName. Checks to see if value is blank and fills in with default if so
        /// otherwise m_firstName takes the passed value
        /// </summary>
        public string firstName
        {
            get { return m_firstName; }
            set
            {
                if (value.Equals(""))
                    m_firstName = "John";
                else
                    m_firstName = value;
            }
        }


        /// <summary>
        /// Getter/Setter for m_lastName. Checks to see if value is blank and fills in a default if so
        /// otherwise m_lastName takes the passed value
        /// </summary>
        public string lastName
        {
            get { return m_lastName; }
            set
            {
                if (value.Equals(""))
                    m_lastName = "Doe";
                else
                    m_lastName = value;
            }
        }

        /// <summary>
        /// Overrides the default ToString() method to display the Student object using
        /// its members. It's also formatted to display whole 4 digit student ID numbers
        /// and the correct GPA representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0:0000} {1} {2} {3:0.0} \n", m_studentID, m_firstName, m_lastName, m_GPA );
        }

    }
}
