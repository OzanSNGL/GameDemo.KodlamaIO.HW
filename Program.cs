﻿using System;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;
using GameDemo.KodlamaIO.HW.Concrete;
using System.Collections.Generic;

namespace GameDemo.KodlamaIO.HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game { GameID = 1, GameName = "Doom Eternal", GamePrice = 60, GameStock = 451, IsOnSale = false };
            Game game2 = new Game { GameID = 2, GameName = "Cyberpunk 2077", GamePrice = 70, GameStock = 1332, IsOnSale = false };
            Game game3 = new Game { GameID = 3, GameName = "GTA V", GamePrice = 30, GameStock = 54, IsOnSale = true };
            Game game4 = new Game { GameID = 4, GameName = "Civilization VI", GamePrice = 35, GameStock = 12, IsOnSale = true };
            Game game5 = new Game { GameID = 5, GameName = "Red Dead Redemption", GamePrice = 80, GameStock = 101, IsOnSale = true };

            Game[] games = new Game[] { game1, game2, game3, game4 };
            List<Game> lstGames = new List<Game> { game1, game2, game3, game4 };

            Customer customer1 = new Customer {Id = 1, FirstName = "Ozan", LastName = "Şengül", Password = "123", DateOfBirth=new DateTime(1997,11,05), NationalityID="29300054534" };
            Customer customer2 = new Customer { Id = 2, FirstName = "Tuncay", LastName = "Göçkon", Password = "321", DateOfBirth = new DateTime(1997, 07, 30), NationalityID = "21568251100" };
            Customer customer3 = new Customer { Id = 3, FirstName = "Defne", LastName = "Demirbaş", Password = "000", DateOfBirth = new DateTime(1998, 09, 05), NationalityID = "13450066892" };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            Offer offer1 = new Offer { GameName = "Red Dead Redemption II", Discount = 30, OfferEnds = new DateTime(2021, 04, 01) };

            List<Offer> allOffers = new List<Offer> { offer1};

            OfferManager offerManager = new OfferManager();
            GameManager gameManager = new GameManager();
            EDevletManager eDevletManager = new EDevletManager();
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
                menu: Console.WriteLine("Please choose an option: \r\n 1. Player Options \r\n 2. Games");
                string o1 = null;
                o1 = Console.ReadLine();

                switch (o1)
                {
                    case "1":
                        Console.WriteLine("Please choose an option: \r\n 1. Sign Up \r\n 2. Delete Account \r\n 3. Update Account");
                        string o2 = null;
                        o2 = Console.ReadLine();

                        switch (o2)
                        {
                            case "1":
                                Console.WriteLine("Please enter your Nationality ID Number:");
                                string enteredID = null;
                                enteredID = Console.ReadLine();
                                for (int y = 0; y < customers.Length; y++)
                                {
                                    if (enteredID == customers[y].NationalityID)
                                    {
                                        eDevletManager.IsValidCustomer();
                                        customerManager.SignUp(new Customer());
                                        goto menu;
                                    }
                                }
                                Console.WriteLine("You have entered a wrong Nationality ID Number.");
                                break;
                            case "2":
                                Console.WriteLine("Please enter your password to continue:");
                                customerManager.Delete(Console.ReadLine());
                                break;
                            case "3":
                                customerManager.Update();
                                goto menu;
                        }
                        break;
                    case "2":
                        Console.WriteLine("All Games:");
                        gameManager.ListAll(lstGames);
                        Console.WriteLine("------------------");
                        offerManager.ShowOffers(allOffers);
                        Console.WriteLine("------------------");
                        Console.WriteLine("Games on sale:");
                        gameManager.ListOnSale(lstGames);
                        Console.WriteLine("\r\nPlease enter a game ID to continue");
                        int enteredNo = new int();
                        enteredNo = Convert.ToInt32(Console.ReadLine());
                        #region
                        for (int i = 0; i < games.Length; i++)
                        {
                            if (enteredNo == games[i].GameID)
                            {
                                Console.WriteLine("Please choose: \r\n 1. Add to cart \r\n 2. Buy now");
                                string o3 = null;
                                o3 = Console.ReadLine();
                                switch (o3)
                                {
                                    case "1":
                                        gameManager.AddToCart(game2);
                                        Console.WriteLine("You have special offers:");
                                        Console.WriteLine("Rather than $" + game2.GamePrice + "\n");
                                        offerManager.CalculateOffer(game2);
                                        
                                        goto menu;
                                    case "2":
                                        gameManager.BuyNow(game1);
                                        Console.WriteLine("You have special offers:");
                                        Console.WriteLine("Rather than $" + game1.GamePrice + "\n");
                                        offerManager.CalculateOffer(game1);
                                        goto menu;
                                }
                            }
                        }
                        Console.WriteLine("You have entered a false game ID");
                        #endregion
                        goto menu;

                    
                    case "3":
                        customerManager.Update();
                        goto menu;
                }
            }
        }


    }
}
