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
            using (var ctx=new ProjectContext())
            { 
                Adress adress = new Adress();
                adress.Straat = "proventiestraat";
                adress.Huisnummer = 45;
                adress.Gemeente = "Deurne";
                adress.Postcode = "2100";
                adress.Land = "Belgie";
                ctx.Adressen.Add(adress);
                ctx.SaveChanges();

                User user1 = new User();
                user1.Achternaam = "Mohamed";
                user1.Voornaam = "Kaouchi";
                user1.Geboortdatum = DateTime.UtcNow;
                user1.Telefoon = "0032465244199";
                user1.Email = "kaouchi@gmail.com";
                user1.Username = "kaouchi";
                user1.Wachtwoord = "Kaouchi_0000";
                user1.Role = RoleUser.Admin;
                user1.adress = adress;
                ctx.Users.Add(user1);
                ctx.SaveChanges();

                User user2 = new User();
                user2.Achternaam = "Hicham";
                user2.Voornaam = "Rifi";
                user2.Geboortdatum = DateTime.UtcNow;
                user2.Telefoon = "0032465244199";
                user2.Email = "kaouchi@gmail.com";
                user2.Username = "rifi";
                user2.Wachtwoord = "Rifi_0000";
                user2.Role = RoleUser.Magazijnier;
                user2.adress = adress;
                ctx.Users.Add(user2);
                ctx.SaveChanges();

                User user3 = new User();
                user3.Achternaam = "Imad";
                user3.Voornaam = "Berkani";
                user3.Geboortdatum = DateTime.UtcNow;
                user3.Telefoon = "0032465244199";
                user3.Email = "berkani@gmail.com";
                user3.Username = "berkani";
                user3.Wachtwoord = "Berkani_0000";
                user3.Role = RoleUser.Verkoper;
                user3.adress = adress;
                ctx.Users.Add(user3);
                ctx.SaveChanges();



                Klant klant1 = new Klant();
                klant1.Voornaam = "Zaaj";
                klant1.achternaam = "Omar";
                klant1.Geboortdatum = DateTime.UtcNow;
                klant1.Telefoon1 = "0032465244199";
                klant1.Telefoon2 = "0032465244199";
                klant1.Email = "zaaj@gmail.com";
                klant1.adress = adress;
                klant1.IngevoegdDoor = user1;
                klant1.IsBedrijf = true;
                klant1.BTWNummer = "00000000000000";
                klant1.Commentaar = "X bedrijf in Leuven.";

                Klant klant2 = new Klant();
                klant2.Voornaam = "Jawad";
                klant2.achternaam = "Filaoui";
                klant2.Geboortdatum = DateTime.UtcNow;
                klant2.Telefoon1 = "0032465244199";
                klant2.Telefoon2 = "0032465244199";
                klant2.Email = "filaoui@gmail.com";
                klant2.adress = adress;
                klant2.IngevoegdDoor = user1;
                klant2.IsBedrijf = true;
                klant2.BTWNummer = "00000000000000";
                klant2.Commentaar = "X bedrijf in Gent.";

                Klant klant3 = new Klant();
                klant3.Voornaam = "Aberkane";
                klant3.achternaam = "Mostapha";
                klant3.Geboortdatum = DateTime.UtcNow;
                klant3.Telefoon1 = "0032465244199";
                klant3.Telefoon2 = "0032465244199";
                klant3.Email = "aberkane@gmail.com";
                klant3.adress = adress;
                klant3.IngevoegdDoor = user1;
                klant3.IsBedrijf = true;
                klant3.BTWNummer = "00000000000000";
                klant3.Commentaar = "X bedrijf in Brussel.";

                Klant klant4 = new Klant();
                klant4.Voornaam = "Ifkiran";
                klant4.achternaam = "Soufiane";
                klant4.Geboortdatum = DateTime.UtcNow;
                klant4.Telefoon1 = "0032465244199";
                klant4.Telefoon2 = "0032465244199";
                klant4.Email = "ifkiran@gmail.com";
                klant4.adress = adress;
                klant4.IngevoegdDoor = user1;
                klant4.IsBedrijf = true;
                klant4.BTWNummer = "00000000000000";
                klant4.Commentaar = "X bedrijf in Antwerpen.";


                Bezorger bezorger = new Bezorger();
                bezorger.Naam = "DHL";
                bezorger.Omschrijving = "Brussel transporter";
                bezorger.Telefoon1 = "0032465244199";
                bezorger.Telefoon2 = "0032465244199";
                bezorger.Email = "dhl@dhl.com";
                bezorger.adress = adress;

                Bezorger bezorger0 = new Bezorger();
                bezorger0.Naam = "PostNL";
                bezorger0.Omschrijving = "Nederland transporter";
                bezorger0.Telefoon1 = "0032465244199";
                bezorger0.Telefoon2 = "0032465244199";
                bezorger0.Email = "postnl@postnl.com";
                bezorger0.adress = adress;

                Levrancier levancier = new Levrancier();
                levancier.Naam = "HP Company";
                levancier.Omschrijving = "Hardware";
                levancier.Telefoon1 = "0032465244199";
                levancier.Telefoon2 = "0032465244199";
                levancier.Email = "hp@hp.com";
                levancier.adress = adress;

                Levrancier levancier0 = new Levrancier();
                levancier0.Naam = "IT Company";
                levancier0.Omschrijving = "Software";
                levancier0.Telefoon1 = "0032465244199";
                levancier0.Telefoon2 = "0032465244199";
                levancier0.Email = "it@it.com";
                levancier0.adress = adress;





                Product product = new Product();
                product.ProductNaam = "Muis HP";
                product.levrancier = levancier;
                product.UnitPrice=24.99;
                product.UnitsOnStock = 100;
                product.ProductNummer = "0001";
                product.BarCode = "0101010101";
                product.Gewicht = 1;
                product.Breedte = 1;
                product.Hoogte = 1;
                product.Lengte = 1;
                product.Omschrijving = "Lazer muis";

                Product product1 = new Product();
                product1.ProductNaam = "Keyboard HP";
                product1.levrancier = levancier;
                product1.UnitPrice = 29.99;
                product1.UnitsOnStock = 100;
                product1.ProductNummer = "0001";
                product1.BarCode = "0101010101";
                product1.Gewicht = 1;
                product1.Breedte = 1;
                product1.Hoogte = 1;
                product1.Lengte = 1;
                product1.Omschrijving = "draadlos keyboard";

                Product product2 = new Product();
                product2.ProductNaam = "Camera HP";
                product2.levrancier = levancier;
                product2.UnitPrice = 24.99;
                product2.UnitsOnStock = 200;
                product2.ProductNummer = "0001";
                product2.BarCode = "0101010101";
                product2.Gewicht = 1;
                product2.Breedte = 1;
                product2.Hoogte = 1;
                product2.Lengte = 1;
                product2.Omschrijving = "Cam 8 Mpixels";

                Product product3 = new Product();
                product3.ProductNaam = "batterij HP";
                product3.levrancier = levancier;
                product3.UnitPrice = 24.99;
                product3.UnitsOnStock = 50;
                product3.ProductNummer = "0001";
                product3.BarCode = "0101010101";
                product3.Gewicht = 1;
                product3.Breedte = 1;
                product3.Hoogte = 1;
                product.Lengte = 1;
                product3.Omschrijving = "X maat";

                Product product4 = new Product();
                product4.ProductNaam = "Scherm HP";
                product4.levrancier = levancier;
                product4.UnitPrice = 24.99;
                product4.UnitsOnStock = 20;
                product4.ProductNummer = "0001";
                product4.BarCode = "0101010101";
                product4.Gewicht = 1;
                product4.Breedte = 1;
                product4.Hoogte = 1;
                product4.Lengte = 1;
                product4.Omschrijving = "X maat";
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
        static public User user;
    }
    
}
