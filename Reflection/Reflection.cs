
// Amir Moeini Rad
// August 20, 2025

// Main Concept: Reflection in C#
// This code demonstrates how to use reflection to get member information of a class.
// Reflection means examining the metadata of types at runtime.
// The 'Type' and 'MemberInfo' classes are used for this purpose.


using System;
using System.Reflection;


namespace ReflectionDemo
{
    class MyMemberInfo
    {
        public static void Main()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Relection in C#.NET.");
            Console.WriteLine("--------------------\n");



            // Get the Type and Member information for the built-in 'PropertyInfo' class.
            string myClass = "System.Reflection.PropertyInfo";



            Console.WriteLine("Following is the member information for the .NET class: {0}", myClass);



            // The 'Type' class is used to get the type of a class.
            Type MyClassType = Type.GetType(myClass);



            // The 'GetMembers()' method is used to get the public members of a class.
            // The 'MemberInfo' class obtains information or metadata about the members of a class.
            MemberInfo[] MyClassMembersArray = MyClassType.GetMembers();



            // Get the number of members in the class and their names.
            Console.WriteLine("\nThere are {0} members in {1}:\n", MyClassMembersArray.GetLength(0), MyClassType.FullName);
            
            for (int counter = 0; counter < MyClassMembersArray.GetLength(0); counter++)
            {
                Console.WriteLine("{0}. {1} - Member type: {2}", counter + 1, MyClassMembersArray[counter].Name, MyClassMembersArray[counter].MemberType.ToString());
            }


            
            Console.WriteLine("\nDone!");
        }
    }
}