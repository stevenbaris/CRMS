using CustomersAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Data
{
    public static class SeedData
    {
        public static void SeededData(this ModelBuilder modelBuilder)
        {
            var cust = new List<Customer>
            { 
                // id,  firstName,  lastName, sex,  dOB,  email,  phone,  address)
                new Customer(Guid.NewGuid(), "Madeline", "Baxter", "Female",new DateTime(1975, 3, 15), "mauris.sagittis@icloud.edu", "09123546789", "5234 Crossing Street" ),
                new Customer(Guid.NewGuid(), "Agatha", "Abrahamovitz", "Female", new DateTime(1984, 05, 25), "aabrahamovitz0@marketwatch.com", "09601729545", "3 Pepper Wood Center"),
                new Customer(Guid.NewGuid(), "Maia", "Habercham", "Female", new DateTime(1956, 09, 12), "mhabercham1@squidoo.com", "09184621695", "97649 Corry Terrace"),
                new Customer(Guid.NewGuid(), "Alane", "Macrow", "Female", new DateTime(1987, 10, 08), "amacrow2@globo.com", "09276939145", "4608 Raven Parkway"),
                new Customer(Guid.NewGuid(), "Tracy", "Edington", "Male", new DateTime(1964, 09, 01), "tedington3@illinois.edu", "09265235080", "2067 Golden Leaf Circle"),
                new Customer(Guid.NewGuid(), "Hinze", "Simunek", "Male", new DateTime(1954, 05, 30), "hsimunek4@yellowpages.com", "09267006937", "52014 Leroy Hill"),
                new Customer(Guid.NewGuid(), "Angela", "Summerskill", "Female", new DateTime(2006, 07, 24), "asummerskill5@gravatar.com", "09337435073", "673 Autumn Leaf Court"),
                new Customer(Guid.NewGuid(), "Jed", "Browett", "Male", new DateTime(1978, 02, 22), "jbrowett6@mediafire.com", "09143498357", "9 Pleasure Way"),
                new Customer(Guid.NewGuid(), "Georgianna", "Bilson", "Female", new DateTime(1955, 05, 22), "gbilson7@prnewswire.com", "09397882449", "17 Columbus Junction"),
                new Customer(Guid.NewGuid(), "Alister", "Have", "Male", new DateTime(2002, 01, 29), "ahave8@so-net.ne.jp", "09638397843", "82368 Boyd Point"),
                new Customer(Guid.NewGuid(), "Kerianne", "Hadlington", "Female", new DateTime(2001, 12, 20), "khadlington9@paypal.com", "09225056729", "59830 Brickson Park Road"),
                new Customer(Guid.NewGuid(), "Meggy", "Crummay", "Female", new DateTime(1994, 05, 30), "mcrummaya@tripod.com", "09392511444", "624 Buhler Point"),
                new Customer(Guid.NewGuid(), "Catlin", "Akram", "Female", new DateTime(1997, 04, 02), "cakramb@wsj.com", "09093870858", "64071 Acker Park"),
                new Customer(Guid.NewGuid(), "Trenton", "Canto", "Male", new DateTime(1965, 01, 28), "tcantoc@msu.edu", "09809339189", "58172 Ruskin Crossing"),
                new Customer(Guid.NewGuid(), "Montague", "Mularkey", "Male", new DateTime(1996, 06, 20), "mmularkeyd@typepad.com", "09306995169", "1 Pond Center"),
                new Customer(Guid.NewGuid(), "Morganica", "Merryfield", "Female", new DateTime(1953, 03, 19), "mmerryfielde@nih.gov", "09003901945", "4526 Northfield Road"),
                new Customer(Guid.NewGuid(), "Con", "Thomkins", "Female", new DateTime(1997, 07, 03), "cthomkinsf@etsy.com", "09939955254", "03722 Westridge Court"),
                new Customer(Guid.NewGuid(), "Rudy", "Morgan", "Male", new DateTime(1972, 06, 26), "rmorgang@bbc.co.uk", "09597429865", "62956 1st Street"),
                new Customer(Guid.NewGuid(), "Rhianna", "Skedge", "Female", new DateTime(1992, 08, 24), "rskedgeh@google.de", "09956873369", "57 Hagan Point"),
                new Customer(Guid.NewGuid(), "Farlee", "Stower", "Male", new DateTime(1991, 05, 16), "fstoweri@engadget.com", "09579026072", "9664 Redwing Court"),
                new Customer(Guid.NewGuid(), "Delano", "Dimnage", "Male", new DateTime(1994, 01, 23), "ddimnagej@etsy.com", "09662401440", "1 Dawn Circle")
            };


            var transact = new List<Transactions>
            {
                new Transactions(Guid.NewGuid(), new DateTime(2022, 11, 09),6068.91M, cust[15].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 05, 30),6523.52M, cust[15].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 04, 23),16861.07M, cust[20].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 04, 27),15743.60M, cust[5].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 02, 15),3896.77M, cust[3].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 07, 30),14115.62M, cust[17].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 11, 28),1347.45M, cust[19].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 17),19644.39M, cust[17].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 11, 08),14420.64M, cust[7].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 01),13405.27M, cust[4].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 01),14215.58M, cust[6].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 05, 16),17181.86M, cust[20].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 10, 27),12838.18M, cust[14].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 27),3399.04M, cust[13].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 10, 26),19017.30M, cust[1].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 06, 14),12621.27M, cust[11].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 04, 12),8205.19M, cust[7].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 11, 11),18900.31M, cust[16].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 22),19958.59M, cust[20].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 04),13524.20M, cust[20].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 05, 15),7914.91M, cust[19].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 29),14447.04M, cust[9].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 04, 12),4079.20M, cust[13].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 16),17809.47M, cust[18].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 03, 05),12163.93M, cust[4].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 03, 15),10839.38M, cust[8].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 14),17362.33M, cust[3].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 02, 26),15326.44M, cust[7].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 02, 06),15225.41M, cust[9].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 02, 25),8243.38M, cust[2].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 08, 21),19646.52M, cust[16].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 13),5587.62M, cust[18].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 03, 09),8628.20M, cust[15].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 01),3134.06M, cust[9].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 11),7895.30M, cust[14].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 10, 10),2116.34M, cust[15].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 30),14523.92M, cust[2].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 27),15192.52M, cust[13].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 05, 19),11703.50M, cust[5].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 07),9842.85M, cust[19].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 11, 04),3940.43M, cust[18].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 08, 02),13910.67M, cust[8].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 04, 25),1183.59M, cust[12].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 25),12396.27M, cust[3].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 07, 04),18095.37M, cust[12].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 14),7388.27M, cust[14].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 09, 29),5204.34M, cust[15].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 02, 14),14562.70M, cust[20].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2023, 01, 26),12432.71M, cust[12].Customer_Id),
                new Transactions(Guid.NewGuid(), new DateTime(2022, 12, 20),9929.75M, cust[17].Customer_Id),

            };

            var user = new List<ApplicationUser>
            {
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "su@crms.com",
                        NormalizedUserName = "su@crms.com".ToUpper(),
                        Email = "su@crms.com",
                        NormalizedEmail = "su@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Super",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "user@crms.com",
                        NormalizedUserName = "user@crms.com".ToUpper(),
                        Email = "user@crms.com",
                        NormalizedEmail = "user@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "user123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Regular",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    }
            };

            modelBuilder.Entity<Customer>().HasData(cust);
            modelBuilder.Entity<Transactions>().HasData(transact);
            modelBuilder.Entity<ApplicationUser>().HasData(user);
        }
    }
}
