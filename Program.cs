using System;
using System.Collections.Generic;
using System.Linq;

public class listMobil
{
    public int IDRegistrasi { get; set; }
    public string Tipe { get; set; }
    public string Merk { get; set; }
    public string Varian { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<listMobil> ListMobil = new listMobil[]
        {
                new listMobil()
                {
                    IDRegistrasi = 001, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86"
                },
                new listMobil()
                {
                    IDRegistrasi = 002, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4"
                },
                new listMobil()
                {
                    IDRegistrasi = 003, Tipe = "Sedan", Merk = "Honda", Varian = "Accord"
                },
                new listMobil()
                {
                    IDRegistrasi = 004, Tipe = "SUV", Merk = "Honda", Varian = "CRV"
                },
                new listMobil()
                {
                    IDRegistrasi = 005, Tipe = "Sedan", Merk = "Honda", Varian = "City"
                }
        };


        // ============================== 1. Test Data Structure - Uji tes kemampuan LINQ menggunakan Lambda Function

        //Pertanyaan: 
        //1. Tampilkan data pertama yang memiliki merk "Honda" 
        //2. Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan" 
        //3. Tampilkan data pertama yang memiliki merk "Honda" dan punya varian "City" 
        //4. Tampilkan data default yang memiliki merk "Toyota" 
        //5. Tampilkan 3 data apa saja  Format tampilan : IDRegistrasi, Merk, Varian

        Console.WriteLine("############## Jawaban Test 1 ##############");
        Console.WriteLine("== Jawaban 1 ==");
        listMobil query1 = ListMobil.Where(x => x.Merk == "Honda").FirstOrDefault();
        Console.WriteLine("Id= " + query1.IDRegistrasi + ", Merk= " + query1.Merk + ", Varian= " + query1.Varian);
        Console.WriteLine();

        Console.WriteLine("== Jawaban 2 ==");
        listMobil query2 = ListMobil.Where(x => x.Merk == "Honda" && x.Tipe == "Sedan").OrderByDescending(y => y.IDRegistrasi).Take(1).FirstOrDefault();
        Console.WriteLine("Id= " + query2.IDRegistrasi + ", Merk= " + query2.Merk + ", Varian= " + query2.Varian);
        Console.WriteLine();

        Console.WriteLine("== Jawaban 3 ==");
        listMobil query3 = ListMobil.Where(x => x.Merk == "Honda" && x.Varian == "City").FirstOrDefault();
        Console.WriteLine("Id= " + query3.IDRegistrasi + ", Merk= " + query3.Merk + ", Varian= " + query3.Varian);
        Console.WriteLine();

        Console.WriteLine("== Jawaban 4 ==");
        foreach (var car in ListMobil.Where(x => x.Merk == "Toyota"))
        {
            Console.WriteLine("Id= " + car.IDRegistrasi + ", Merk= " + car.Merk + ", Varian= " + car.Varian);
        }
        Console.WriteLine();

        Console.WriteLine("== Jawaban 5 ==");
        foreach (var car in ListMobil.ToList().Take(3))
        {
            Console.WriteLine("Id= " + car.IDRegistrasi + ", Merk= " + car.Merk + ", Varian= " + car.Varian);
        }
        Console.WriteLine();


        // ============================== 2. Test Algoritma - Uji tes kemampuan algoritma dalam menampilkan ourput yang diminta
        
        Console.WriteLine("############## Jawaban Test 2 ##############");
        for (int i = 1; i <= 500; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("tik");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("tek");
            }
            else if (i % 7 == 0)
            {
                Console.WriteLine("tok");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }
}
