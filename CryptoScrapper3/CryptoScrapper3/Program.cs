﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CryptoScrapper3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new CryptoCurrencyEntities())
            {
                Console.WriteLine("Enter data on a crypto currency");
                var coinName = "Bitcoin";
                var coinSymbol = "BTC";
                var marketCap = 13453;
                var price = 6920;
                var circulatingSupply = 1679;
                var volume24hr = 832649;
                var changeHour = 61;
                var change24hr = 90;
                var changeDay = 38;


                var cryptoTable = new CryptoTable
                {
                    Id = 1,
                    Name = coinName,
                    Symbol = coinSymbol,
                    MarketCap = marketCap,
                    Price = price,
                    CirculatingSupply = circulatingSupply,
                    Volume24Hour = volume24hr,
                    ChangeHour = changeHour,
                    Change24Hour = change24hr,
                    ChangeDay = changeDay
                };

                db.CryptoTables.Add(cryptoTable);
                db.SaveChanges();
            }
        }
    }
}
