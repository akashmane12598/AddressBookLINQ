using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book LINQ!");

            Console.WriteLine();
            Console.WriteLine("UC2 Created DataTable for AddressBook");
            Management.CreateTable_UC2();

            Console.WriteLine();
            Console.WriteLine("UC3 Insert Row into DataTable AddressBook");
            Management.InsertRowIntoTable_UC3();
        }
    }
}
