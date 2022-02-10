using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //MAKING EMPLOYEES

            var e1 = new Employee { EmployeeId = 1, SSN = 158306166430, FirstName = "Axel", LastName = "Oxenstierna" };
            var e2 = new Employee { EmployeeId = 2, SSN = 191243568790, FirstName = "Klonky", LastName = "Donky" };
            var e3 = new Employee { EmployeeId = 3, SSN = 196901011234, FirstName = "Hugo Bosse", LastName = "Malmberg" };
            var e4 = new Employee { EmployeeId = 4, SSN = 197303172143, FirstName = "Fialotta", LastName = "Galén" };
            var e5 = new Employee { EmployeeId = 5, SSN = 198412136718, FirstName = "Klas", LastName = "Muckberg" };
            var e6 = new Employee { EmployeeId = 6, SSN = 199304302112, FirstName = "Emil", LastName = "Lime" };
            var e7 = new Employee { EmployeeId = 7, SSN = 200108214763, FirstName = "Emma", LastName = "Klohonen Johansson" };
            var e8 = new Employee { EmployeeId = 8, SSN = 200108245261, FirstName = "Emmsan", LastName = "Johanssonskan" };


            //MAKING EMAILS

            var email1 = new Email { EmployeeId = 1, EmployeeEmail = "haringenmail@sojas.se" };
            var email2 = new Email { EmployeeId = 2, EmployeeEmail = "klonk@donk.se" };
            var email3 = new Email { EmployeeId = 2, EmployeeEmail = "klonkydonk@sojas.se" };
            var email4 = new Email { EmployeeId = 3, EmployeeEmail = "hugoisboss@sojas.se" };
            var email5 = new Email { EmployeeId = 3, EmployeeEmail = "hugobossemalm@sojas.se" };
            var email6 = new Email { EmployeeId = 4, EmployeeEmail = "fiaargalen@sojas.se" };
            var email7 = new Email { EmployeeId = 4, EmployeeEmail = "f.galen@sojas.se" };
            var email8 = new Email { EmployeeId = 5, EmployeeEmail = "kalasklas@sojas.se" };
            var email9 = new Email { EmployeeId = 6, EmployeeEmail = "emillime@sojas.se" };
            var email10 = new Email { EmployeeId = 7, EmployeeEmail = "emmatheclone@sojas.se" };
            var email11 = new Email { EmployeeId = 8, EmployeeEmail = "johoemm@sojas.se" };


            //MAKING PHONENUMBERS

            var ph1 = new PhoneNumber { EmployeeId = 1, EmployeePhoneNumber = "1111111111" };
            var ph2 = new PhoneNumber { EmployeeId = 2, EmployeePhoneNumber = "0792761426" };
            var ph3 = new PhoneNumber { EmployeeId = 3, EmployeePhoneNumber = "0726384950" };
            var ph4 = new PhoneNumber { EmployeeId = 3, EmployeePhoneNumber = "0705636178" };
            var ph5 = new PhoneNumber { EmployeeId = 4, EmployeePhoneNumber = "0794563832" };
            var ph6 = new PhoneNumber { EmployeeId = 5, EmployeePhoneNumber = "0734591435" };
            var ph7 = new PhoneNumber { EmployeeId = 5, EmployeePhoneNumber = "0824527501" };
            var ph8 = new PhoneNumber { EmployeeId = 6, EmployeePhoneNumber = "0768546326" };
            var ph9 = new PhoneNumber { EmployeeId = 6, EmployeePhoneNumber = "0106793264" };
            var ph10 = new PhoneNumber { EmployeeId = 7, EmployeePhoneNumber = "0704923456" };
            var ph11 = new PhoneNumber { EmployeeId = 8, EmployeePhoneNumber = "0736785437" };


            //MAKING PRODUCTS

            //Ingredient(List), IngredientId(List) 
            //Bröd
            var pr1 = new Product { ProductId = 1, Name = "Tunnbröd", Price = 29, ExpirationDate = DateTime.Parse("2022-01-23"), AmountInStore = 2, LastCheckedDate = DateTime.Parse("2021-12-31"), LastCheckedByEmployeeId = 4 };
            var pr2 = new Product { ProductId = 2, Name = "Korvbröd", Price = 24, ExpirationDate = DateTime.Parse("2022-01-13"), AmountInStore = 23, LastCheckedDate = DateTime.Parse("2021-12-31"), LastCheckedByEmployeeId = 3 };

            //Dryck
            var pr3 = new Product { ProductId = 3, Name = "RedBull", Price = 16, ExpirationDate = DateTime.Parse("2023-07-12"), AmountInStore = 73, LastCheckedDate = DateTime.Parse("2021-07-26"), LastCheckedByEmployeeId = 3 };
            var pr4 = new Product { ProductId = 4, Name = "CocaCola", Price = 11, ExpirationDate = DateTime.Parse("2023-09-02"), AmountInStore = 58, LastCheckedDate = DateTime.Parse("2021-09-14"), LastCheckedByEmployeeId = 6 };

            //Frukt
            var pr5 = new Product { ProductId = 5, Name = "Passionsfrukt", Price = 4, ExpirationDate = DateTime.Today, AmountInStore = 2, LastCheckedDate = DateTime.Today, LastCheckedByEmployeeId = 4 };
            var pr6 = new Product { ProductId = 6, Name = "Gröna äpplen, Granny Smith", Price = 6, ExpirationDate = DateTime.Today, AmountInStore = 49, LastCheckedDate = DateTime.Today, LastCheckedByEmployeeId = 2 };

            //Kött
            var pr7 = new Product { ProductId = 7, Name = "Oxfilé", Price = 399, ExpirationDate = DateTime.Parse("2023-01-19"), AmountInStore = 3, LastCheckedDate = DateTime.Parse("2021-12-30"), LastCheckedByEmployeeId = 3 };
            var pr8 = new Product { ProductId = 8, Name = "Fläskfilé", Price = 199, ExpirationDate = DateTime.Parse("2023-01-03"), AmountInStore = 17, LastCheckedDate = DateTime.Parse("2021-12-30"), LastCheckedByEmployeeId = 7 };

            //Mejeri
            var pr9 = new Product { ProductId = 9, Name = "Mjölk", Price = 14, ExpirationDate = DateTime.Parse("2023-01-14"), AmountInStore = 0, LastCheckedDate = DateTime.Parse("2021-11-02"), LastCheckedByEmployeeId = 6 };
            var pr10 = new Product { ProductId = 10, Name = "Vispgrädde", Price = 25, ExpirationDate = DateTime.Parse("2023-01-31"), AmountInStore = 35, LastCheckedDate = DateTime.Parse("2021-11-02"), LastCheckedByEmployeeId = 5 };

            //Skafferi
            var pr11 = new Product { ProductId = 11, Name = "Ströbröd", Price = 14, ExpirationDate = DateTime.Parse("2023-11-29"), AmountInStore = 2, LastCheckedDate = DateTime.Parse("2021-08-21"), LastCheckedByEmployeeId = 3 };
            var pr12 = new Product { ProductId = 12, Name = "Mjöl", Price = 23, ExpirationDate = DateTime.Parse("2023-12-04"), AmountInStore = 13, LastCheckedDate = DateTime.Parse("2021-10-12"), LastCheckedByEmployeeId = 2 };
            var pr13 = new Product { ProductId = 13, Name = "Vanillinsocker", Price = 34, ExpirationDate = DateTime.Parse("2024-02-13"), AmountInStore = 17, LastCheckedDate = DateTime.Parse("2021-11-12"), LastCheckedByEmployeeId = 1 };

            //MAKING DEPARTMENTS
            var d1 = new Department { DepartmentId = 1, Name = "Bröd", EmployeeId = 3 };
            var d2 = new Department { DepartmentId = 2, Name = "Dryck", EmployeeId = 4 };
            var d3 = new Department { DepartmentId = 3, Name = "Frukt", EmployeeId = 1 };
            var d4 = new Department { DepartmentId = 4, Name = "Kött", EmployeeId = 1 };
            var d5 = new Department { DepartmentId = 5, Name = "Mejeri", EmployeeId = 6 };
            var d6 = new Department { DepartmentId = 6, Name = "Skafferi", EmployeeId = 3 };

            var depProd1 = new DepartmentProduct { ProductId = 1, DepartmentId = 1 };
            var depProd2 = new DepartmentProduct { ProductId = 2, DepartmentId = 1 };
            var depProd3 = new DepartmentProduct { ProductId = 11, DepartmentId = 1 };
            var depProd4 = new DepartmentProduct { ProductId = 3, DepartmentId = 2 };
            var depProd5 = new DepartmentProduct { ProductId = 4, DepartmentId = 2 };
            var depProd6 = new DepartmentProduct { ProductId = 5, DepartmentId = 3 };
            var depProd7 = new DepartmentProduct { ProductId = 6, DepartmentId = 3 };
            var depProd8 = new DepartmentProduct { ProductId = 13, DepartmentId = 3 };
            var depProd9 = new DepartmentProduct { ProductId = 7, DepartmentId = 4 };
            var depProd10 = new DepartmentProduct { ProductId = 8, DepartmentId = 4 };
            var depProd11 = new DepartmentProduct { ProductId = 2, DepartmentId = 4 };
            var depProd12 = new DepartmentProduct { ProductId = 9, DepartmentId = 5 };
            var depProd13 = new DepartmentProduct { ProductId = 10, DepartmentId = 5 };
            var depProd14 = new DepartmentProduct { ProductId = 11, DepartmentId = 6 };
            var depProd15 = new DepartmentProduct { ProductId = 12, DepartmentId = 6 };
            var depProd16 = new DepartmentProduct { ProductId = 13, DepartmentId = 6 };




            //MAKING INGREDIENTS
            var i1 = new Ingredient { IngredientId = 1, Name = "Mjöl" };
            var i2 = new Ingredient { IngredientId = 2, Name = "Jäst" };
            var i3 = new Ingredient { IngredientId = 3, Name = "Salt" };
            var i4 = new Ingredient { IngredientId = 4, Name = "Vatten" };
            var i5 = new Ingredient { IngredientId = 5, Name = "Mjölk" };
            var i6 = new Ingredient { IngredientId = 6, Name = "Smör" };
            var i7 = new Ingredient { IngredientId = 7, Name = "Socker" };
            var i8 = new Ingredient { IngredientId = 8, Name = "Aromer" };
            var i9 = new Ingredient { IngredientId = 9, Name = "Passionsfrukt" };
            var i10 = new Ingredient { IngredientId = 10, Name = "Gröna äpplen" };
            var i11 = new Ingredient { IngredientId = 11, Name = "Oxfilé" };
            var i12 = new Ingredient { IngredientId = 12, Name = "Fläskfilé" };
            var i13 = new Ingredient { IngredientId = 13, Name = "Smulat bröd" };
            var i14 = new Ingredient { IngredientId = 14, Name = "Vanilj" };

            var prodIngr1 = new ProductIngredient { ProductId = 1, IngredientId = 1 };
            var prodIngr2 = new ProductIngredient { ProductId = 1, IngredientId = 2 };
            var prodIngr3 = new ProductIngredient { ProductId = 1, IngredientId = 3 };
            var prodIngr4 = new ProductIngredient { ProductId = 1, IngredientId = 5 };
            var prodIngr5 = new ProductIngredient { ProductId = 1, IngredientId = 6 };

            var prodIngr6 = new ProductIngredient { ProductId = 2, IngredientId = 1 };
            var prodIngr7 = new ProductIngredient { ProductId = 2, IngredientId = 2 };
            var prodIngr8 = new ProductIngredient { ProductId = 2, IngredientId = 3 };
            var prodIngr9 = new ProductIngredient { ProductId = 2, IngredientId = 5 };
            var prodIngr10 = new ProductIngredient { ProductId = 2, IngredientId = 6 };

            var prodIngr11 = new ProductIngredient { ProductId = 3, IngredientId = 7 };
            var prodIngr12 = new ProductIngredient { ProductId = 3, IngredientId = 8 };
            var prodIngr13 = new ProductIngredient { ProductId = 3, IngredientId = 3 };

            var prodIngr14 = new ProductIngredient { ProductId = 4, IngredientId = 7 };
            var prodIngr15 = new ProductIngredient { ProductId = 4, IngredientId = 8 };
            var prodIngr16 = new ProductIngredient { ProductId = 4, IngredientId = 9 };

            var prodIngr17 = new ProductIngredient { ProductId = 5, IngredientId = 9 }; //Passion
            var prodIngr18 = new ProductIngredient { ProductId = 6, IngredientId = 10 };//Gröna äpplen
            var prodIngr19 = new ProductIngredient { ProductId = 7, IngredientId = 11 };//Oxfile
            var prodIngr20 = new ProductIngredient { ProductId = 8, IngredientId = 12 };//Fläskfile

            var prodIngr21 = new ProductIngredient { ProductId = 9, IngredientId = 5 };//Mjölk
            var prodIngr22 = new ProductIngredient { ProductId = 10, IngredientId = 5 };//Vispgrädde
            var prodIngr23 = new ProductIngredient { ProductId = 11, IngredientId = 14 };//Ströbröd
            var prodIngr24 = new ProductIngredient { ProductId = 12, IngredientId = 1 };//Mjöl
            var prodIngr25 = new ProductIngredient { ProductId = 13, IngredientId = 7 };
            var prodIngr26 = new ProductIngredient { ProductId = 13, IngredientId = 14 };//Vaniljsocker



            //MAKING CAMPAIGNS
            var c1 = new Campaign { CampaignId = 1, PercentPriceDrop = Convert.ToDecimal(0.8) };
            var c2 = new Campaign { CampaignId = 2, PercentPriceDrop = Convert.ToDecimal(0.9) };

            //ADDING CAMPAIGNS TO PRODUCTS
            pr11.IsOnCampaignId = 1;
            pr12.IsOnCampaignId = 1;
            pr13.IsOnCampaignId = 1;
            pr4.IsOnCampaignId = 2;

            //INSERTING EMPLOYEES
            modelBuilder
                .Entity<Employee>()
                .HasData(
                e1, e2, e3, e4, e5, e6, e7, e8);

            //INSERTING EMAILS
            modelBuilder
                .Entity<Email>()
                .HasData(
                email1, email2, email3, email4, email5, email6, email7, email8, email9, email10, email11);

            //INSERTING PHONENUMBERS
            modelBuilder
                .Entity<PhoneNumber>()
                .HasData(
                ph1, ph2, ph3, ph4, ph5, ph6, ph7, ph8, ph9, ph10, ph11);

            //INSERTING PRODUCTS
            modelBuilder.
                Entity<Product>().
                HasData(
                pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8, pr9, pr10, pr11, pr12, pr13);

            //INSERTING DEPARTMENTS
            modelBuilder
                .Entity<Department>()
                .HasData(
            d1, d2, d3, d4, d5, d6);

            //INSERTING INGREDIENTS
            modelBuilder.Entity<Ingredient>()
                .HasData(
                i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14);

            //INSERTING CAMPAIGNS
            modelBuilder.Entity<Campaign>()
                .HasData(
                c1, c2);

            //INSERTING DEPARTMENTPRODUCTS
            modelBuilder.Entity<DepartmentProduct>()
                .HasData(
                depProd1, depProd2, depProd3, depProd4, depProd5, depProd6, depProd7, depProd8, depProd9, depProd10, depProd11, depProd12, depProd13, depProd14, depProd15, depProd16);


            //INSERTING PRODUCTINGREDIENTS
            modelBuilder.Entity<ProductIngredient>()
                .HasData(
                prodIngr1, prodIngr2, prodIngr3, prodIngr4, prodIngr5, prodIngr6, prodIngr7, prodIngr8, prodIngr9, prodIngr10, prodIngr11, prodIngr12, prodIngr13, prodIngr14, prodIngr15,
                prodIngr16, prodIngr17, prodIngr18, prodIngr19, prodIngr20, prodIngr21, prodIngr22, prodIngr23, prodIngr24, prodIngr25, prodIngr26);
        }
    }
}
