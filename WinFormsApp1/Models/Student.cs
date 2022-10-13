﻿namespace WinFormsApp1.Models;

public class Student
{
   

    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateOnly BirthOfDate { get; set; }
    public float Score { get; set; }
    public Student()
    {
        Id = Guid.NewGuid();
    }
    public Student(string firstName, string lastName, DateOnly birthOfDate, float score)
        :this()
    {
        FirstName = firstName;
        LastName = lastName;
        BirthOfDate = birthOfDate;
        Score = score;
    }
    public override string ToString()
    => $"Id : {Id.ToString().Remove(8)}  Firstname: {FirstName}  Date of Birth: {BirthOfDate}   Score: {Score}";
}

