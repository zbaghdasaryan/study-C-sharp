﻿using System;
using System.Collections;

class Book
{
    public Book(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
}

class Library
{
    private Book[] books;

    public Library()
    {
        books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"), new Book("Евгений Онегин") };
    }

    public int Length
    {
        get { return books.Length; }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < books.Length; i++)
        {
            yield return books[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            foreach (Book b in lib)
            {
                Console.WriteLine(b.Name);
            }
            Console.ReadKey();
        }
    }
}