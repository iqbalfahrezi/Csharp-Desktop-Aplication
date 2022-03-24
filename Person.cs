using System;

namespace Registration
{
    internal class Person
    {
        internal string? LastName;

        public string? FirstName { get; internal set; }
        public int Age { get; internal set; }
    }
}

namespace Registration
{
public class person

       {
           private string firstname;
           private string lastname;

           protected string fullName;

           public person()
            :this("guest", "guest")
           {
            
           }

        public person(string firstName, string lastName)
           :this(firstName,lastName,17)
           {
               
           }

           public person(string firstName, string lastName, int age)
           {
               this.firstname = firstName;
               this.lastname = lastName;
               this.age = age;
               totalPerson++;
               this.id = totalPerson;
               fullName = $"{firstName} {lastName}";
           }

           public void greetings()
           {
               Console.WriteLine("hi, my name is {0} {1}", this.firstname, this.lastname);
           }

           public void greetings(person person)
           {
               Console.WriteLine("hi, {0}", person.firstname);
           }

           public string FirstName 
           { 
               get
               {
                   return firstname;
               }
               set
               {
                   if (value != "")
                        firstname = value;
                   else
                        throw new ArgumentException("", "FirstName cannot be empty");
               }
            }

            public string LastName 
           { 
               get
               {
                   return lastname;
               }
               set
               {
                    if (value != "")
                        lastname = value;
                    else
                        throw new ArgumentException("", "LastName cannot be empty");
               } 
            }

           protected int age;
           public virtual int Age
           {
               get
               {
                   return age;
               }
               set
               {
                    if (value>=0)
                        age = value;
                    else
                        throw new ArgumentOutOfRangeException("","age must be greater or equal to zero!");
               }
           }

           public static int totalPerson;

           private readonly int id;

           public int ID
           {
               get
               {
                   return this.id;
               }
               
            }

            public static void GetTotalPerson()
            {
                Console.WriteLine(totalPerson);
            }

            public virtual string Introduce()
            {
                return $"hi, i'm a Person, and my name is {fullName}";
            }
       }
}