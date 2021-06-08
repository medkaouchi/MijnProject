using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnProject
{
    public enum RoleUser { Admin, Magazijnier, Verkoper }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var ctx = new ProjectContext())
            //{
            //    Adress adress = new Adress();
            //    adress.Straat = "proventiestraat";
            //    adress.Huisnummer = 45;
            //    adress.Gemeente = "Deurne";
            //    adress.Postcode = "2100";
            //    adress.Land = "Belgie";
            //    ctx.Adressen.Add(adress);
            //    ctx.SaveChanges();

            //    User user1 = new User();
            //    user1.Achternaam = "Mohamed";
            //    user1.Voornaam = "Kaouchi";
            //    user1.Geboortdatum = DateTime.UtcNow;
            //    user1.Telefoon = "0032465244199";
            //    user1.Email = "kaouchi@gmail.com";
            //    user1.Username = "kaouchi";
            //    user1.Wachtwoord = "Kaouchi_0000";
            //    user1.Role = RoleUser.Admin;
            //    user1.adress = adress;
            //    ctx.Users.Add(user1);
            //    ctx.SaveChanges();

            //    User user2 = new User();
            //    user2.Achternaam = "Hicham";
            //    user2.Voornaam = "Rifi";
            //    user2.Geboortdatum = DateTime.UtcNow;
            //    user2.Telefoon = "0032465244199";
            //    user2.Email = "kaouchi@gmail.com";
            //    user2.Username = "rifi";
            //    user2.Wachtwoord = "Rifi_0000";
            //    user2.Role = RoleUser.Magazijnier;
            //    user2.adress = adress;
            //    ctx.Users.Add(user2);
            //    ctx.SaveChanges();

            //    User user3 = new User();
            //    user3.Achternaam = "Imad";
            //    user3.Voornaam = "Berkani";
            //    user3.Geboortdatum = DateTime.UtcNow;
            //    user3.Telefoon = "0032465244199";
            //    user3.Email = "berkani@gmail.com";
            //    user3.Username = "berkani";
            //    user3.Wachtwoord = "Berkani_0000";
            //    user3.Role = RoleUser.Verkoper;
            //    user3.adress = adress;
            //    ctx.Users.Add(user3);
            //    ctx.SaveChanges();



            //    Klant klant1 = new Klant();
            //    klant1.Voornaam = "Zaaj";
            //    klant1.achternaam = "Omar";
            //    klant1.Geboortdatum = DateTime.UtcNow;
            //    klant1.IngevoegdDatum = DateTime.UtcNow;
            //    klant1.Telefoon1 = "0032465244199";
            //    klant1.Telefoon2 = "0032465244199";
            //    klant1.Email = "zaaj@gmail.com";
            //    klant1.adress = adress;
            //    klant1.IngevoegdDoor = user1;
            //    klant1.IsBedrijf = true;
            //    klant1.BTWNummer = "00000000000000";
            //    klant1.Commentaar = "X bedrijf in Leuven.";
            //    ctx.Klanten.Add(klant1);
            //    ctx.SaveChanges();

            //    Klant klant2 = new Klant();
            //    klant2.Voornaam = "Jawad";
            //    klant2.achternaam = "Filaoui";
            //    klant2.Geboortdatum = DateTime.UtcNow;
            //    klant2.IngevoegdDatum = DateTime.UtcNow;
            //    klant2.Telefoon1 = "0032465244199";
            //    klant2.Telefoon2 = "0032465244199";
            //    klant2.Email = "filaoui@gmail.com";
            //    klant2.adress = adress;
            //    klant2.IngevoegdDoor = user1;
            //    klant2.IsBedrijf = true;
            //    klant2.BTWNummer = "00000000000000";
            //    klant2.Commentaar = "X bedrijf in Gent.";
            //    ctx.Klanten.Add(klant2);
            //    ctx.SaveChanges();

            //    Klant klant3 = new Klant();
            //    klant3.Voornaam = "Aberkane";
            //    klant3.achternaam = "Mostapha";
            //    klant3.Geboortdatum = DateTime.UtcNow;
            //    klant3.IngevoegdDatum = DateTime.UtcNow;
            //    klant3.Telefoon1 = "0032465244199";
            //    klant3.Telefoon2 = "0032465244199";
            //    klant3.Email = "aberkane@gmail.com";
            //    klant3.adress = adress;
            //    klant3.IngevoegdDoor = user2;
            //    klant3.IsBedrijf = true;
            //    klant3.BTWNummer = "00000000000000";
            //    klant3.Commentaar = "X bedrijf in Brussel.";
            //    ctx.Klanten.Add(klant3);
            //    ctx.SaveChanges();

            //    Klant klant4 = new Klant();
            //    klant4.Voornaam = "Ifkiran";
            //    klant4.achternaam = "Soufiane";
            //    klant4.Geboortdatum = DateTime.UtcNow;
            //    klant4.IngevoegdDatum = DateTime.UtcNow;
            //    klant4.Telefoon1 = "0032465244199";
            //    klant4.Telefoon2 = "0032465244199";
            //    klant4.Email = "ifkiran@gmail.com";
            //    klant4.adress = adress;
            //    klant4.IngevoegdDoor = user3;
            //    klant4.IsBedrijf = true;
            //    klant4.BTWNummer = "00000000000000";
            //    klant4.Commentaar = "X bedrijf in Antwerpen.";
            //    ctx.Klanten.Add(klant4);
            //    ctx.SaveChanges();


            //    Bezorger bezorger = new Bezorger();
            //    bezorger.Naam = "DHL";
            //    bezorger.Omschrijving = "Brussel transporter";
            //    bezorger.Telefoon1 = "0032465244199";
            //    bezorger.Telefoon2 = "0032465244199";
            //    bezorger.Email = "dhl@dhl.com";
            //    bezorger.adress = adress;
            //    ctx.Bezorgers.Add(bezorger);
            //    ctx.SaveChanges();

            //    Bezorger bezorger0 = new Bezorger();
            //    bezorger0.Naam = "PostNL";
            //    bezorger0.Omschrijving = "Nederland transporter";
            //    bezorger0.Telefoon1 = "0032465244199";
            //    bezorger0.Telefoon2 = "0032465244199";
            //    bezorger0.Email = "postnl@postnl.com";
            //    bezorger0.adress = adress;
            //    ctx.Bezorgers.Add(bezorger0);
            //    ctx.SaveChanges();

            //    Levrancier levancier = new Levrancier();
            //    levancier.Naam = "HP Company";
            //    levancier.Omschrijving = "Hardware";
            //    levancier.Telefoon1 = "0032465244199";
            //    levancier.Telefoon2 = "0032465244199";
            //    levancier.Email = "hp@hp.com";
            //    levancier.adress = adress;
            //    ctx.Levranciers.Add(levancier);
            //    ctx.SaveChanges();

            //    Levrancier levancier0 = new Levrancier();
            //    levancier0.Naam = "IT Company";
            //    levancier0.Omschrijving = "Software";
            //    levancier0.Telefoon1 = "0032465244199";
            //    levancier0.Telefoon2 = "0032465244199";
            //    levancier0.Email = "it@it.com";
            //    levancier0.adress = adress;
            //    ctx.Levranciers.Add(levancier0);
            //    ctx.SaveChanges();




            //    Product product = new Product();
            //    product.ProductNaam = "Muis HP";
            //    product.levrancier = levancier;
            //    product.UnitPrice = 24.99;
            //    product.UnitsOnStock = 100;
            //    product.ProductNummer = "0001";
            //    product.BarCode = "0101010101";
            //    product.Gewicht = 1;
            //    product.Breedte = 1;
            //    product.Hoogte = 1;
            //    product.Lengte = 1;
            //    product.Omschrijving = "Lazer muis";
            //    ctx.Products.Add(product);
            //    ctx.SaveChanges();

            //    Product product1 = new Product();
            //    product1.ProductNaam = "Keyboard HP";
            //    product1.levrancier = levancier;
            //    product1.UnitPrice = 29.99;
            //    product1.UnitsOnStock = 100;
            //    product1.ProductNummer = "0001";
            //    product1.BarCode = "0101010101";
            //    product1.Gewicht = 1;
            //    product1.Breedte = 1;
            //    product1.Hoogte = 1;
            //    product1.Lengte = 1;
            //    product1.Omschrijving = "draadlos keyboard";
            //    ctx.Products.Add(product1);
            //    ctx.SaveChanges();

            //    Product product2 = new Product();
            //    product2.ProductNaam = "Camera HP";
            //    product2.levrancier = levancier;
            //    product2.UnitPrice = 24.99;
            //    product2.UnitsOnStock = 200;
            //    product2.ProductNummer = "0001";
            //    product2.BarCode = "0101010101";
            //    product2.Gewicht = 1;
            //    product2.Breedte = 1;
            //    product2.Hoogte = 1;
            //    product2.Lengte = 1;
            //    product2.Omschrijving = "Cam 8 Mpixels";
            //    ctx.Products.Add(product2);
            //    ctx.SaveChanges();

            //    Product product3 = new Product();
            //    product3.ProductNaam = "batterij HP";
            //    product3.levrancier = levancier;
            //    product3.UnitPrice = 24.99;
            //    product3.UnitsOnStock = 50;
            //    product3.ProductNummer = "0001";
            //    product3.BarCode = "0101010101";
            //    product3.Gewicht = 1;
            //    product3.Breedte = 1;
            //    product3.Hoogte = 1;
            //    product.Lengte = 1;
            //    product3.Omschrijving = "X maat";
            //    ctx.Products.Add(product3);
            //    ctx.SaveChanges();

            //    Product product4 = new Product();
            //    product4.ProductNaam = "Scherm HP";
            //    product4.levrancier = levancier;
            //    product4.UnitPrice = 24.99;
            //    product4.UnitsOnStock = 20;
            //    product4.ProductNummer = "0001";
            //    product4.BarCode = "0101010101";
            //    product4.Gewicht = 1;
            //    product4.Breedte = 1;
            //    product4.Hoogte = 1;
            //    product4.Lengte = 1;
            //    product4.Omschrijving = "X maat";
            //    ctx.Products.Add(product4);
            //    ctx.SaveChanges();


            //    Order order = new Order();
            //    order.OrderDatum = DateTime.UtcNow;
            //    order.status = OrderStatus.Gereserveerd;
            //    order.klant = klant1;
            //    order.user = user1;
            //    order.BezorgdAdress = adress;
            //    order.BezorgdDoor = bezorger;
            //    ctx.Orders.Add(order);
            //    ctx.SaveChanges();

            //    Order order1 = new Order();
            //    order1.OrderDatum = DateTime.UtcNow;
            //    order1.status = OrderStatus.Gereserveerd;
            //    order1.klant = klant1;
            //    order1.user = user2;
            //    order1.BezorgdAdress = adress;
            //    order1.BezorgdDoor = bezorger0;
            //    ctx.Orders.Add(order1);
            //    ctx.SaveChanges();

            //    Order order2 = new Order();
            //    order2.OrderDatum = DateTime.UtcNow;
            //    order2.status = OrderStatus.Gereserveerd;
            //    order2.klant = klant2;
            //    order2.user = user1;
            //    order2.BezorgdAdress = adress;
            //    order2.BezorgdDoor = bezorger;
            //    ctx.Orders.Add(order2);
            //    ctx.SaveChanges();

            //    Order order3 = new Order();
            //    order3.OrderDatum = DateTime.UtcNow;
            //    order3.status = OrderStatus.Gereserveerd;
            //    order3.klant = klant2;
            //    order3.user = user2;
            //    order3.BezorgdAdress = adress;
            //    order3.BezorgdDoor = bezorger0;
            //    ctx.Orders.Add(order3);
            //    ctx.SaveChanges();

            //    Order order4 = new Order();
            //    order4.OrderDatum = DateTime.UtcNow;
            //    order4.status = OrderStatus.Gereserveerd;
            //    order4.klant = klant3;
            //    order4.user = user3;
            //    order4.BezorgdAdress = adress;
            //    order4.BezorgdDoor = bezorger0;
            //    ctx.Orders.Add(order4);
            //    ctx.SaveChanges();

            //    Order order5 = new Order();
            //    order5.OrderDatum = DateTime.UtcNow;
            //    order5.status = OrderStatus.Gereserveerd;
            //    order5.klant = klant4;
            //    order5.user = user2;
            //    order5.BezorgdAdress = adress;
            //    order5.BezorgdDoor = bezorger0;
            //    ctx.Orders.Add(order5);
            //    ctx.SaveChanges();


            //    OrderDetail ordetail = new OrderDetail();
            //    ordetail.Aantal = 5;
            //    ordetail.order = order;
            //    ordetail.product = product;
            //    ctx.OrderDetails.Add(ordetail);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail1 = new OrderDetail();
            //    ordetail1.Aantal = 15;
            //    ordetail1.order = order;
            //    ordetail1.product = product1;
            //    ctx.OrderDetails.Add(ordetail1);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail2 = new OrderDetail();
            //    ordetail2.Aantal = 5;
            //    ordetail2.order = order1;
            //    ordetail2.product = product2;
            //    ctx.OrderDetails.Add(ordetail2);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail3 = new OrderDetail();
            //    ordetail3.Aantal = 10;
            //    ordetail3.order = order1;
            //    ordetail3.product = product4;
            //    ctx.OrderDetails.Add(ordetail3);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail4 = new OrderDetail();
            //    ordetail4.Aantal = 5;
            //    ordetail4.order = order2;
            //    ordetail4.product = product3;
            //    ctx.OrderDetails.Add(ordetail4);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail5 = new OrderDetail();
            //    ordetail5.Aantal = 2;
            //    ordetail5.order = order2;
            //    ordetail5.product = product2;
            //    ctx.OrderDetails.Add(ordetail5);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail6 = new OrderDetail();
            //    ordetail6.Aantal = 15;
            //    ordetail6.order = order3;
            //    ordetail6.product = product1;
            //    ctx.OrderDetails.Add(ordetail6);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail7 = new OrderDetail();
            //    ordetail7.Aantal = 10;
            //    ordetail7.order = order5;
            //    ordetail7.product = product;
            //    ctx.OrderDetails.Add(ordetail7);
            //    ctx.SaveChanges();

            //    OrderDetail ordetail8 = new OrderDetail();
            //    ordetail8.Aantal = 5;
            //    ordetail8.order = order4;
            //    ordetail8.product = product3;
            //    ctx.OrderDetails.Add(ordetail8);
            //    ctx.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
        static public User user;
    }
    
}
