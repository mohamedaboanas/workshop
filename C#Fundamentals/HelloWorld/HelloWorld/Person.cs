using System;

namespace HelloWorld
{
    public class Person
    {
        // properity will create this, it is an example for encapsultion - information hiding
        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        //prop

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // C# create provate field for us
        // private for set it once and will readonly you can not change it
        public DateTime Birthdate { get; private set; }

        //ctor
        public Person()
        {

        }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //Calc
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;

            }
        }


       //Method
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, FirstName);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.FirstName = str;

            return person;
        }

       
    }


}