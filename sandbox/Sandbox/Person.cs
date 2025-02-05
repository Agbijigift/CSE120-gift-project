using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
class Person
{
public string _firstName;
public string _lastName;
public int _age;
public Person(string firstname, string lastname, int age)
{
   _firstName = firstname;
   _lastName = lastname;
   _age = age; 
}
public void fullName()
{
    Console.WriteLine($"{_firstName} {_lastName}");
}
}

