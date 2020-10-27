using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysList
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfFriends = int.Parse(Console.ReadLine());
            List<string> firstNames = new List<string>();//[noOfFriends];
            List<string> lastNames = new List<string>()  ;// ing[noOfFriends];
            List<string> telephones = new List<string>();//[noOfFriends];
            List<string> datesOfBirth = new List<string>();//[noOfFriends];
            loopToGetData(noOfFriends, firstNames, lastNames, telephones, datesOfBirth);
            
        }

        static void AskUserDetails(string message, List<string> array)
        {
            Console.WriteLine(message);
            array.Add(Console.ReadLine());
        }

        static void loopToGetData(int noOfFriends, List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirth)
        {
            for (int i = 0; i < noOfFriends; i++)
            {
                AskUserDetails("Give me your first name:", firstNames);
                AskUserDetails("Give me your last name:", lastNames);
                AskUserDetails("Give me your telephones:", telephones);
                AskUserDetails("Give me your dateofbirth:", datesOfBirth);
            }
        }


        // static void PrinABirthday(List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirth,int i)
        // static void PrintAllBirthdays(List<string> firstNames,List<string> lasttNames,
        //                               List<string> telePhones,List<string> dateOfBirth)
        // static void PrintABirthday(List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirth
        //string firstName,string lastName); na einai idiio to onoma kai to epitheto
        // static void PrintABirthday(List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirths,tring birthday)
        // static void PrintABirthday(List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirth,string telephone)
        // static void PrintABirthday(List<string> firstNames, List<string> lastNames, List<string> telephones, List<string> datesOfBirth,string firstName,string lastName,
        //string telePhone,string birthday)

    }



}




