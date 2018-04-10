using System.Collections.Generic;
using System.Data.Entity;

namespace RocketNetV2.Models
{
  public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Grass"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Fire"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Water"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Electric"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Ground"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Fighting"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Normal"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Poison"
                },new Category
                {
                    CategoryID = 9,
                    CategoryName = "Ghost"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Psychic"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Flying"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Dragon"
                },
                new Category
                {
                    CategoryID = 13,
                    CategoryName = "Ice"
                },
                new Category
                {
                    CategoryID = 14,
                    CategoryName = "Rock"
                },
                new Category
                {
                    CategoryID = 15,
                    CategoryName = "Bug"
                },

            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
      var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "abra",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagePath="abra.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "aerodactyl",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="aerodactyl.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
                     //CategoryID2 = 8 //this is not currently working
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "alakazam",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath="alakazam.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "arbok",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="arbok.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "arcaine",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    ImagePath="arcaine.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "articuno",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="articuno.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "beedrill",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="beedrill.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "bellsprout",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="bellsprout.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "blastoise",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="blastoise.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "bulbasaur",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="bulbasaur.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "butterfree",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="butterfre.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "caterpie",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath="caterpie.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "chansey",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="chansey.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "charizard",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    ImagePath="charizard.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "charmander",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="charmander.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "charmeleon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="charmeleon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "clefable",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="clefable.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "clefairy",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="clefairy.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "cloyster",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="cloyster.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "cubone",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="cubone.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dewgone",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dewgong.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "diglett",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="diglett.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "ditto",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ditto.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dodrio",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dodrio.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "doduo",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="doduo.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dragonair",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dragonair.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dragonite",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dragonite.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dratini",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dratini.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "drowzee",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="drowzee.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dugtrio",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="dugtrio.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "eevee",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="eevee.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "ekans",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ekans.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "electabuzz",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="electabuzz.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "electrode",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="electrode.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "exeggcute",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="exeggcute.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "exeggutor",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="exeggutor.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "farfetchd",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="farfetchd.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "fearow",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="fearow.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "flareon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="flareon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gastly",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="gastly.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gengar",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="gengar.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "geodude",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="geodude.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gloom",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="gloom.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golbat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="golbat.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "goldeen",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="goldeen.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golduck",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="golduck.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golem",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="golem.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "graveler",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="graveler.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "grimer",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="grimer.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "growlithe",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="growlithe.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gyarados",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="gyarados.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "haunter",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="haunter.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hitmonchan",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="hitmonchan.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hitmonlee",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="hitmonlee.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "horsea",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="horsea.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hypno",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="hypno.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ivysaur",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ivysaur.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jigglypuff",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="jigglypuff.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jolteon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="jolteon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jynx",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="jynx.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kabuto",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kabuto.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kabutops",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kabutops.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kadabra",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kadabra.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kakuna",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kakuna.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kangaskhan",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kangaskhan.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kingler",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="kingler.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "koffing",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="koffing.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },


                new Product
                {
                    ProductID = 15,
                    ProductName = "krabby",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="krabby.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "lapras",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="lapras.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "lickitung",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="lickitung.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machamp",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="machamp.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machoke",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="machoke.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machop",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="machop.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magikarp",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="magikarp.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magmar",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="magmar.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magnemite",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="magnemite.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magneton",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="magneton.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mankey",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="mankey.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "marowak",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="marowak.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "meowth",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="meowth.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "metapod",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="metapod.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mew",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="mew.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mewtwo",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="mewtwo.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "moltres",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="moltres.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mr-mime",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="mr-mime.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "muk",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="muk.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoking",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidoking.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoqueen",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidoqueen.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoran-f",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidoran-f.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoran-m",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidoran-m.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4

                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidorina",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidorina.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidorino",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="nidorino.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ninetales",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ninetales.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "oddish",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="oddish.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "omanyte",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="omanyte.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "omastar",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="omastar.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "onix",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="onix.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "paras",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="paras.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "parasect",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="parasect.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "persian",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="persian.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgeot",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="pidgeot.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgeotto",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="pidgeotto.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgey",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="pidgey.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pikachu",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="pikachu.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pinsir",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="pinsir.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwag",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="poliwag.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwhirl",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="poliwhirl.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwrath",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="poliwrath.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ponyta",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ponyta.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "porygon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="porygon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "primeape",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="primeape.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "psyduck",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="psyduck.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "raichu",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="raichu.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rapidash",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="rapidash.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "raticate",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="raticate.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rattata",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="rattata.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rhydon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="rhydon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ryhorn",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="ryhorn.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "sandshrew",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="sandshrew.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "sandslash",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="sandslash.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "scyther",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="scyther.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seadra",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="seadra.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seaking",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="seaking.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seel",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="seel.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "shellder",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="shellder.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "slowbro",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="slowbro.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "slowpoke",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="slowpoke.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "snorlax",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="snorlax.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "spearow",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="spearow.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "squirtle",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="squirtle.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "starmie",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="starmie.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "staryu",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="staryu.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tangela",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="tangela.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tauros",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="tauros.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tentacool",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="tentacool.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tentacruel",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="tentacruel.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vaporeon",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="vaporeon.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venomoth",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="venomoth.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venonat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="venonat.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venusaur",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="venusaur.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "victreebel",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="victreebel.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vileplume",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="vileplume.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "voltrob",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="voltrob.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vulpix",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="vulpix.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "wartotle",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="wartotle.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weedle",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="weedle.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weepinbell",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="weepinbell.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weezing",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="weezing.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "wigglytuff",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="wigglytuff.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "zapdos",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="zapdos.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "zubat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="zubat.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                }
            };
      return products;
    }
  }
}