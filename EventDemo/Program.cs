using EventDemo;
using System;

Student s1 = new() { Name = "jon", Age = 10 };
Student s2 = new() { Name = "bob", Age = 20 };

s1.StudentAgeChanged += e => Console.WriteLine($"Old age: {e.OldAge}, New age: {e.NewAge}");
s2.StudentAgeChanged += e => Console.WriteLine($"Old age: {e.OldAge}, New age: {e.NewAge}");

s1.Age++;
s2.Age = 45;

/*
Output:

Old age: 10, New age: 11
Old age: 20, New age: 45
*/