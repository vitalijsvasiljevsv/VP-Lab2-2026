﻿using Lab2.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new CarDbContext();
            //ADD record

            //var owner2 = new Owner
            //{
            //    Name = "Vitālijs",
            //    Surname = "Vasiļjevs",
            //    Number = "+37120293843"
            //};
            //db.Add(owner2);
            //db.SaveChanges();

            // UPDATE record


            //var owner2 = db.Owners.FirstOrDefault(o => o.Id == 1);

            //if (owner2 != null)
            //{
            //    owner2.Surname = "Ozols";
            //    db.SaveChanges();
            //}


            // DELETE record

            //var owner2 = db.Owners.FirstOrDefault(o => o.Id == 1);

            //if (owner2 != null)
            //{
            //    db.Remove(owner2);
            //    db.SaveChanges();
            //}

            //LINQ
            var owner = db.Owners
                .Include(o=>o.Cars)
                .FirstOrDefault(o => o.Name.StartsWith("V"));

            if (owner != null)
            {
                WriteLine(owner.Name);
            }

            var owners = db.Owners.Where(s => s.Surname.Contains("s"));

            foreach (var own in owners)
            {
                WriteLine(own.Name +" "+ own.Surname);
            }

        }

        static void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}