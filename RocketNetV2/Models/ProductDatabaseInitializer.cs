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
                    Description = "Using its ability to read minds, it will identify impending danger and TELEPORT to safety.", 
                    ImagePath="abra.jpg",
                    UnitPrice = 15.50,
                    CategoryID = 10
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "aerodactyl",
                    Description = "A savage Pokémon that died out in ancient times. It was resurrected using DNA taken from amber.",
                    ImagePath="aerodactyl.jpg",
                    UnitPrice = 45.00,
                    CategoryID = 14, //also 11
                    CategoryID2 = 11
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "alakazam",
                    Description = "A Pokémon that can memorize anything. It never forgets what it learns - that's why this Pokémon is smart.",
                    ImagePath="alakazam.jpg",
                    UnitPrice = 65.00,
                    CategoryID = 10
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "arbok",
                    Description = "The frightening patterns on its belly have been studied. Six variations have been confirmed.",
                    ImagePath="arbok.jpg",
                    UnitPrice = 35.00,
                    CategoryID = 8
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "arcanine",
                    Description = "A legendary Pokémon in China. Many people are charmed by its grace and beauty while running.",
                    ImagePath="arcanine.jpg",
                    UnitPrice = 125.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "articuno",
                    Description = "A legendary bird Pokémon. It freezes water that is contained in winter air and makes it snow.",
                    ImagePath="articuno.jpg",
                    UnitPrice = 9999.99,
                    CategoryID = 13
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "beedrill",
                    Description = "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.",
                    ImagePath="beedrill.jpg",
                    UnitPrice = 7.95,
                    CategoryID = 15
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "bellsprout",
                    Description = "Prefers hot and humid places. It ensnares tiny insects with its vines and devours them.",
                    ImagePath="bellsprout.jpg",
                    UnitPrice = 11.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "blastoise",
                    Description = "Once it takes aim at its enemy, it blasts out water with even more force than a fire hose.",
                    ImagePath="blastoise.jpg",
                    UnitPrice = 85.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "bulbasaur",
                    Description = "A strange seed was planted on its back at birth. The plant sprouts and grows with this POKéMON.",
                    ImagePath="bulbasaur.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "butterfree",
                    Description = "Its wings, covered with poisonous powders, repel water. This allows it to fly in the rain.",
                    ImagePath="butterfree.jpg",
                    UnitPrice = 19.25,
                    CategoryID = 15
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "caterpie",
                    Description = "If you touch the feeler on top of its head, it will release a horrible stink to protect itself.",
                    ImagePath="caterpie.jpg",
                    UnitPrice = 5.00,
                    CategoryID = 15
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "chansey",
                    Description = "A gentle and kind-hearted Pokémon that shares its nutritious eggs if it sees an injured Pokémon.",
                    ImagePath="chansey.jpg",
                    UnitPrice = 46.50,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "charizard",
                    Description = "When expelling a blast of super hot fire, the red flame on the tip of its tail burns more intensely.",
                    ImagePath="charizard.jpg",
                    UnitPrice = 75.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "charmander",
                    Description = "The flame at the tip of its tail makes a sound as it burns. You can only hear it in quiet places.",
                    ImagePath="charmander.jpg",
                    UnitPrice = 9.45,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "charmeleon",
                    Description = "Tough fights could excite this Pokémon. When excited, it may blow out bluish-white flames.",
                    ImagePath="charmeleon.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "clefable",
                    Description = "They appear to be very protective of their own world. It is a kind of fairy, rarely seen by people.",
                    ImagePath="clefable.jpg",
                    UnitPrice = 55.50,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "clefairy",
                    Description = "Adored for their cute looks and playfulness. They are thought to be rare, as they do not appear often.",
                    ImagePath="clefairy.jpg",
                    UnitPrice = 30.25,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "cloyster",
                    Description = "For protection, it uses its harder-than-diamonds shell. It also shoots spikes from the shell.",
                    ImagePath="cloyster.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "cubone",
                    Description = "Wears the skull of its deceased mother. Its cries echo inside the skull and come out as a sad melody.",
                    ImagePath="cubone.jpg",
                    UnitPrice = 13.25,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dewgone",
                    Description = "Its entire body is a snowy-white. Unharmed by even intense cold, it swims powerfully in icy waters.",
                    ImagePath="dewgong.jpg",
                    UnitPrice = 50.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "diglett",
                    Description = "It prefers dark places. It spends most of its time underground, though it may pop up in caves.",
                    ImagePath="diglett.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "ditto",
                    Description = "When it spots an enemy, its body transforms into an almost perfect copy of its opponent.",
                    ImagePath="ditto.jpg",
                    UnitPrice = 65.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dodrio",
                    Description = "One of Doduo's two heads splits to form a unique species. It runs close to 40 MPH in prairies.",
                    ImagePath="dodrio.jpg",
                    UnitPrice = 17.35,
                    CategoryID = 11
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "doduo",
                    Description = "Its short wings make flying difficult. Instead, this Pokémon runs at high speed on developed legs.",
                    ImagePath="doduo.jpg",
                    UnitPrice = 6.35,
                    CategoryID = 11
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dragonair",
                    Description = "According to a witness, its body was surrounded by a strange aura that gave it a mystical look.",
                    ImagePath="dragonair.jpg",
                    UnitPrice = 56.00,
                    CategoryID = 12
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dragonite",
                    Description = "It is said that this Pokémon lives somewhere in the sea and that it flies. However, it is only a rumor.",
                    ImagePath="dragonite.jpg",
                    UnitPrice = 78.00,
                    CategoryID = 12
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dratini",
                    Description = "The existence of this mythical Pokémon was only recently confirmed by a fisherman who caught one.",
                    ImagePath="dratini.jpg",
                    UnitPrice = 33.50,
                    CategoryID = 12
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "drowzee",
                    Description = "If you sleep by it all the time, it will sometimes show you dreams it has eaten in the past.",
                    ImagePath="drowzee.jpg",
                    UnitPrice = 27.95,
                    CategoryID = 10
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "dugtrio",
                    Description = "A team of triplets that can burrow over 60 MPH. Due to this, some people think it's an earthquake.",
                    ImagePath="dugtrio.jpg",
                    UnitPrice = 38.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "eevee",
                    Description = "Its genetic code is unstable, so it could evolve in a variety of ways. There are only a few alive.",
                    ImagePath="eevee.jpg",
                    UnitPrice = 22.25,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "ekans",
                    Description = "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.",
                    ImagePath="ekans.jpg",
                    UnitPrice = 8.00,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "electabuzz",
                    Description = "If a major power outage occurs, it is certain that this Pokémon has eaten electricity at a power plant.",
                    ImagePath="electabuzz.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "electrode",
                    Description = "Stores electrical energy inside its body. Even the slightest shock could trigger a huge explosion.",
                    ImagePath="electrode.jpg",
                    UnitPrice = 52.50,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "exeggcute",
                    Description = "The heads attract each other and spin around. There must be six heads for it to maintain balance.",
                    ImagePath="exeggcute.jpg",
                    UnitPrice = 13.50,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "exeggutor",
                    Description = "Its cries are very noisy. This is because each of the three heads thinks about whatever it likes.",
                    ImagePath="exeggutor.jpg",
                    UnitPrice = 45.25,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "farfetchd",
                    Description = "Lives where reedy plants grow. They are rarely seen, so it's thought their numbers are decreasing.",
                    ImagePath="farfetchd.jpg",
                    UnitPrice = 11.25,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "fearow",
                    Description = "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly.",
                    ImagePath="fearow.jpg",
                    UnitPrice = 24.00,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "flareon",
                    Description = "It has a flame chamber inside its body. It inhales, then blows out fire that is over 3,000F degrees.",
                    ImagePath="flareon.jpg",
                    UnitPrice = 37.89,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gastly",
                    Description = "Said to appear in decrepit, deserted buildings. It has no real shape as it appears to be made of a gas.",
                    ImagePath="gastly.jpg",
                    UnitPrice = 6.75,
                    CategoryID = 9
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gengar",
                    Description = "A Gengar is close by if you feel a sudden chill. It may be trying to lay a curse on you.",
                    ImagePath="gengar.jpg",
                    UnitPrice = 31.25,
                    CategoryID = 9
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "geodude",
                    Description = "Commonly found near mountain trails, etc. If you step on one by accident, it gets angry.",
                    ImagePath="geodude.jpg",
                    UnitPrice = 18.65,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gloom",
                    Description = "Smells incredibly foul! However, around 1 out of 1,000 people enjoy sniffing its nose-bending stink.",
                    ImagePath="gloom.jpg",
                    UnitPrice = 12.95,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golbat",
                    Description = "It attacks in a stealthy manner, without warning. Its sharp fangs are used to bite and suck blood.",
                    ImagePath="golbat.jpg",
                    UnitPrice = 29.50,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "goldeen",
                    Description = "Touching the back fin causes numbness. It hooks its tail to coral to stay in place while sleeping.",
                    ImagePath="goldeen.jpg",
                    UnitPrice = 36.25,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golduck",
                    Description = "Its slim and long limbs end in broad flippers. They are used for swimming gracefully in lakes.",
                    ImagePath="golduck.jpg",
                    UnitPrice = 66.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "golem",
                    Description = "Once it sheds its skin, its body turns tender and whitish. Its hide hardens when it's exposed to air.",
                    ImagePath="golem.jpg",
                    UnitPrice = 68.25,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "graveler",
                    Description = "Often seen rolling down mountain trails. Obstacles are just things to roll straight over, not avoid.",
                    ImagePath="graveler.jpg",
                    UnitPrice = 48.50,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "grimer",
                    Description = "Made of hardened sludge. It smells too putrid to touch. Even weeds won't grow in its path.",
                    ImagePath="grimer.jpg",
                    UnitPrice = 32.00,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "growlithe",
                    Description = "A Pokémon with a friendly nature. However, it will bark fiercely at anything invading its territory.",
                    ImagePath="growlithe.jpg",
                    UnitPrice = 7.95,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "gyarados",
                    Description = "Brutally vicious and enormously destructive. Known for totally destroying cities in ancient times.",
                    ImagePath="gyarados.jpg",
                    UnitPrice = 70.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "haunter",
                    Description = "By licking, it saps the victim's life. It causes shaking that won't stop until the victim's demise.",
                    ImagePath="haunter.jpg",
                    UnitPrice = 42.50,
                    CategoryID = 9
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hitmonchan",
                    Description = "Punches in corkscrew fashion. It can punch its way through a concrete wall in the same way as a drill.",
                    ImagePath="hitmonchan.jpg",
                    UnitPrice = 50.25,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hitmonlee",
                    Description = "When kicking, the sole of its foot turns as hard as a diamond on impact and destroys its enemy.",
                    ImagePath="hitmonlee.jpg",
                    UnitPrice = 51.50,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "horsea",
                    Description = "If it senses danger, it will vigorously spray water or a special type of ink from its mouth.",
                    ImagePath="horsea.jpg",
                    UnitPrice = 11.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "hypno",
                    Description = "Avoid eye contact if you come across one. It will try to put you to sleep by using its pendulum.",
                    ImagePath="hypno.jpg",
                    UnitPrice = 26.75,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ivysaur",
                    Description = "The bulb on its back grows by drawing energy. It gives off an aroma when it is ready to bloom.",
                    ImagePath="ivysaur.jpg",
                    UnitPrice = 31.25,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jigglypuff",
                    Description = "Uses its alluring eyes to enrapture its foe. It then sings a pleasing melody that lulls the foe to sleep.",
                    ImagePath="jigglypuff.jpg",
                    UnitPrice = 28.90,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jolteon",
                    Description = "A sensitive Pokémon that easily becomes sad or angry. Every time its mood changes, it charges power.",
                    ImagePath="jolteon.jpg",
                    UnitPrice = 46.25,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "jynx",
                    Description = "Appears to move to a rhythm of its own, as if it were dancing. It wiggles its hips as it walks.",
                    ImagePath="jynx.jpg",
                    UnitPrice = 35.00,
                    CategoryID = 13
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kabuto",
                    Description = "A Pokémon that was recovered from a fossil. It uses the eyes on its back while hiding on the sea floor.",
                    ImagePath="kabuto.jpg",
                    UnitPrice = 3.95,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kabutops",
                    Description = "A slim and fast swimmer. It slices its prey with its sharp sickles and drinks the body fluids.",
                    ImagePath="kabutops.jpg",
                    UnitPrice = 19.20,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kadabra",
                    Description = "Many odd things happen if this Pokémon is close by. For example, it makes clocks run backwards.",
                    ImagePath="kadabra.jpg",
                    UnitPrice = 27.30,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kakuna",
                    Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.",
                    ImagePath="kakuna.jpg",
                    UnitPrice = 8.50,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kangaskhan",
                    Description = "Raises its young in its belly pouch. Won't run from any fight to keep its young protected.",
                    ImagePath="kangaskhan.jpg",
                    UnitPrice = 66.50,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "kingler",
                    Description = "One claw grew massively and as hard as steel. It has 10,000-HP strength. However, it is too heavy.",
                    ImagePath="kingler.jpg",
                    UnitPrice = 32.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "koffing",
                    Description = "In hot places, its internal gases could expand and explode without any warning. Be very careful!",
                    ImagePath="koffing.jpg",
                    UnitPrice = 13.50,
                    CategoryID = 8
                },


                new Product
                {
                    ProductID = 15,
                    ProductName = "krabby",
                    Description = "Its pincers are superb weapons. They sometimes break off during battle, but they grow back fast.",
                    ImagePath="krabby.jpg",
                    UnitPrice = 5.55,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "lapras",
                    Description = "A gentle soul that can read the minds of people. It can ferry people across the sea on its back.",
                    ImagePath="lapras.jpg",
                    UnitPrice = 80.25,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "lickitung",
                    Description = "Its tongue spans almost 7 feet and moves more freely than its forelegs. Its licks can cause paralysis.",
                    ImagePath="lickitung.jpg",
                    UnitPrice = 49.50,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machamp",
                    Description = "One arm alone can move mountains. Using all four arms, this Pokémon fires off awesome punches.",
                    ImagePath="machamp.jpg",
                    UnitPrice = 10.00,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machoke",
                    Description = "The belt around its waist holds back its energy. Without it, this Pokémon would be unstoppable.",
                    ImagePath="machoke.jpg",
                    UnitPrice = 58.95,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "machop",
                    Description = "Very powerful in spite of its small size. Its mastery of many types of martial arts makes it very tough.",
                    ImagePath="machop.jpg",
                    UnitPrice = 42.50,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magikarp",
                    Description = "Famous for being very unreliable. It can be found swimming in seas, lakes, rivers, and shallow puddles.",
                    ImagePath="magikarp.jpg",
                    UnitPrice = 0.01,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magmar",
                    Description = "Borin in an active volcano. Its body is always cloaked in flames, so it looks like a big ball of fire.",
                    ImagePath="magmar.jpg",
                    UnitPrice = 52.25,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magnemite",
                    Description = "It is born with the ability to defy gravity. It floats in air on powerful electromagnetic waves.",
                    ImagePath="magnemite.jpg",
                    UnitPrice = 15.50,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "magneton",
                    Description = "Generates strange radio signals. It raises the temperature by 3.6F degrees within 3,300 feet.",
                    ImagePath="magneton.jpg",
                    UnitPrice = 51.50,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mankey",
                    Description = "An agile Pokémon that lives in trees. It angers easily and will not hesitate to attack anything.",
                    ImagePath="mankey.jpg",
                    UnitPrice = 17.00,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "marowak",
                    Description = "Small and weak, this Pokémon is adept with its bone club. It has grown more vicious over the ages.",
                    ImagePath="marowak.jpg",
                    UnitPrice = 39.50,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "meowth",
                    Description = "Appears to be more active at night. It loves round and shiny things. It can't stop from picking them up.",
                    ImagePath="meowth.jpg",
                    UnitPrice = 7.95,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "metapod",
                    Description = "Hardens its shell to protect itself. However, a large impact may cause it to pop out of its shell.",
                    ImagePath="metapod.jpg",
                    UnitPrice = 7.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mew",
                    Description = "When viewed through a microscope, this Pokémon's short fine, delicate hair can be seen.",
                    ImagePath="mew.jpg",
                    UnitPrice = 15000000.00,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mewtwo",
                    Description = "Its DNA is almost the same as Mew's. However, its size and disposition are vastly different.",
                    ImagePath="mewtwo.jpg",
                    UnitPrice = 6000000.00,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "moltres",
                    Description = "A legendary bird Pokémon. As it flaps its flaming wings, even the night sky will turn red.",
                    ImagePath="moltres.jpg",
                    UnitPrice = 9999.99,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "mr-mime",
                    Description = "It is adept at conning people. It is said to be able to create walls out of thin air by miming.",
                    ImagePath="mr-mime.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "muk",
                    Description = "Smells so awful, it can cause fainting. Through degeneration, it lost its sense of smell.",
                    ImagePath="muk.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoking",
                    Description = "Its steel-like hide adds to its powerful tackle. Its horns are so hard, they can pierce a diamond.",
                    ImagePath="nidoking.jpg",
                    UnitPrice = 60.00,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoqueen",
                    Description = "Tough scales cover the sturdy body of this Pokémon. It appears that the scales grow in cycles.",
                    ImagePath="nidoqueen.jpg",
                    UnitPrice = 62.50,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoran-f",
                    Description = "A mild-mannered Pokémon that does not like to fight. Beware, its small horns secrete venom.",
                    ImagePath="nidoran-f.jpg",
                    UnitPrice = 17.50,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidoran-m",
                    Description = "Its large ears are always kept upright. If it senses danger, it will attack with a poisonous sting.",
                    ImagePath="nidoran-m.jpg",
                    UnitPrice = 18.25,
                    CategoryID = 8

                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidorina",
                    Description = "A mild-mannered Pokémon that does not like to fight. Beware, its small horns secrete venom.",
                    ImagePath="nidorina.jpg",
                    UnitPrice = 9.45,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "nidorino",
                    Description = "Its horns contain venom. If they are stabbed into an enemy, the impact makes the poison leak out.",
                    ImagePath="nidorino.jpg",
                    UnitPrice = 8.45,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ninetales",
                    Description = "According to an enduring legend, nine noble saints were united and reincarnated as this Pokémon.",
                    ImagePath="ninetales.jpg",
                    UnitPrice = 57.00,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "oddish",
                    Description = "It may be mistaken for a clump of weeds. If you try to yank it out of the ground, it shrieks horribly.",
                    ImagePath="oddish.jpg",
                    UnitPrice = 7.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "omanyte",
                    Description = "An ancient Pokémon that was recovered from a fossil. It swims by cleverly twisting its 10 tentacles about.",
                    ImagePath="omanyte.jpg",
                    UnitPrice = 32.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "omastar",
                    Description = "Sharp beaks ring its mouth. Its shell was too big for it to move freely, so it became extinct.",
                    ImagePath="omastar.jpg",
                    UnitPrice = 48.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "onix",
                    Description = "Burrows at high speed in search of food. The tunnels it leaves are used as homes by Digletts.",
                    ImagePath="onix.jpg",
                    UnitPrice = 48.90,
                    CategoryID = 14
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "paras",
                    Description = "Burrows under the ground to gnaw on tree roots. The mushrooms on its back absorb most of the nutrition.",
                    ImagePath="paras.jpg",
                    UnitPrice = 6.95,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "parasect",
                    Description = "The bug host is drained of energy by the mushrooms on its back. They appear to do all the thinking.",
                    ImagePath="parasect.jpg",
                    UnitPrice = 17.00,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "persian",
                    Description = "The gem on its forehead glows on its own! It walks with all the grace and elegance of a proud queen.",
                    ImagePath="persian.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgeot",
                    Description = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.",
                    ImagePath="pidgeot.jpg",
                    UnitPrice = 42.25,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgeotto",
                    Description = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey.",
                    ImagePath="pidgeotto.jpg",
                    UnitPrice = 18.50,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pidgey",
                    Description = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.",
                    ImagePath="pidgey.jpg",
                    UnitPrice = 3.95,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pikachu",
                    Description = "It keeps its tail raised to monitor its surroundings. If you yank its tail, it will try to bite you.",
                    ImagePath="pikachu.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "pinsir",
                    Description = "Grips its prey in its pincers and squeezes hard! It can't move if it's cold, so it lives in warm places.",
                    ImagePath="pinsir.jpg",
                    UnitPrice = 42.25,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwag",
                    Description = "The direction of the spiral on the belly differs by area. It is more adept at swimming than walking.",
                    ImagePath="poliwag.jpg",
                    UnitPrice = 8.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwhirl",
                    Description = "Under attack, it uses its belly spiral to put the foe to sleep. It then makes its escape.",
                    ImagePath="poliwhirl.jpg",
                    UnitPrice = 22.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "poliwrath",
                    Description = "Swims powerfully using all the muscles in its body. It can even overtake champion swimmers.",
                    ImagePath="poliwrath.jpg",
                    UnitPrice = 53.25,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "ponyta",
                    Description = "Capable of jumping incredibly high. Its hooves and sturdy legs absorb the impact of a hard landing.",
                    ImagePath="ponyta.jpg",
                    UnitPrice = 21.50,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "porygon",
                    Description = "The only Pokémon people anticipate can fly into space. None has managed the feat yet, however.",
                    ImagePath="porygon.jpg",
                    UnitPrice = 49.50,
                    CategoryID = 10
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "primeape",
                    Description = "It stops being angry only when nobody else is around. To view this moment is very difficult.",
                    ImagePath="primeape.jpg",
                    UnitPrice = 38.95,
                    CategoryID = 6
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "psyduck",
                    Description = "Always tormented by headaches. It uses psychic powers, but it is not known if it intends to do so.",
                    ImagePath="psyduck.jpg",
                    UnitPrice = 2.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "raichu",
                    Description = "When electricity builds up inside its body, it becomes feisty. It also glows in the dark.",
                    ImagePath="raichu.jpg",
                    UnitPrice = 60.00,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rapidash",
                    Description = "Just loves to run. If it sees something faster than itself, it will give chase at top speed.",
                    ImagePath="rapidash.jpg",
                    UnitPrice = 58.00,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "raticate",
                    Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.",
                    ImagePath="raticate.jpg",
                    UnitPrice = 18.00,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rattata",
                    Description = "Will chew on anything with its fangs. If you see one, it is certain that 40 more live in the area.",
                    ImagePath="rattata.jpg",
                    UnitPrice = 2.00,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rhydon",
                    Description = "Walks on its hind legs. Shows signs of intelligence. Its armor-like hide even repels molten lava.",
                    ImagePath="rhydon.jpg",
                    UnitPrice = 26.50,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "rhyhorn",
                    Description = "A Pokémon with a one-track mind. Once it charges, it won't stop running until it falls asleep.",
                    ImagePath="rhyhorn.jpg",
                    UnitPrice = 60.25,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "sandshrew",
                    Description = "Its body is dry. When it gets cold at night, its hide is said to become coated with a fine dew.",
                    ImagePath="sandshrew.jpg",
                    UnitPrice = 6.50,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "sandslash",
                    Description = "It is skilled at slashing enemies with its claws. If broken, they start to grow back in a day.",
                    ImagePath="sandslash.jpg",
                    UnitPrice = 32.50,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "scyther",
                    Description = "Leaps out of tall grass and slices prey with its scythes. The movement looks like that of a ninja.",
                    ImagePath="scyther.jpg",
                    UnitPrice = 55.00,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seadra",
                    Description = "Touching the back fin causes numbness. It hooks its tail to coral to stay in place while sleeping.",
                    ImagePath="seadra.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seaking",
                    Description = "It is the male's job to make a nest by carving out boulders in a stream using the horn on its head.",
                    ImagePath="seaking.jpg",
                    UnitPrice = 40.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "seel",
                    Description = "Loves freezing cold conditions. Relishes swimming in a frigid climate of around 14F degrees.",
                    ImagePath="seel.jpg",
                    UnitPrice = 15.55,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "shellder",
                    Description = "The shell can withstand any attack. However, when it is open, the tender body is exposed.",
                    ImagePath="shellder.jpg",
                    UnitPrice = 4.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "slowbro",
                    Description = "Lives lazily by the sea. If the Shellder on its tail comes off, it becomes a Slowpoke again.",
                    ImagePath="slowbro.jpg",
                    UnitPrice = 19.95,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "slowpoke",
                    Description = "Incredibly slow and sluggish. It is quite content to loll about without worrying about the time.",
                    ImagePath="slowpoke.jpg",
                    UnitPrice = 9.95,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "snorlax",
                    Description = "Will eat anything, even if the food happens to be a little moldy. It never gets an upset stomach.",
                    ImagePath="snorlax.jpg",
                    UnitPrice = 58.00,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "spearow",
                    Description = "Inept at flying high. However, it can fly around very fast to protect its territory.",
                    ImagePath="spearow.jpg",
                    UnitPrice = 3.50,
                    CategoryID = 11
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "squirtle",
                    Description = "Shoots water at prey while in the water. Withdraws into its shell when in danger.",
                    ImagePath="squirtle.jpg",
                    UnitPrice = 12.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "starmie",
                    Description = "The center section is named the core. People think it is communicating when it glows in 7 colors.",
                    ImagePath="starmie.jpg",
                    UnitPrice = 10.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "staryu",
                    Description = "As long as the center section is unharmed, it can grow back fully even if it is chopped to bits.",
                    ImagePath="staryu.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tangela",
                    Description = "Its identity is obscured by masses of thick, blue vines. The vines are said to stop growing.",
                    ImagePath="tangela.jpg",
                    UnitPrice = 13.50,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tauros",
                    Description = "A rowdy Pokémon with a lot of stamina. Once running, it won't stop until it hits something.",
                    ImagePath="tauros.jpg",
                    UnitPrice = 63.00,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tentacool",
                    Description = "It can sometimes be found all dry and shriveled up on a beach. Toss it back into the sea to revive it.",
                    ImagePath="tentacool.jpg",
                    UnitPrice = 7.85,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "tentacruel",
                    Description = "Its 80 tentacles can stretch and contract freely. They wrap around prey and weaken it with poison.",
                    ImagePath="tentacruel.jpg",
                    UnitPrice = 16.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vaporeon",
                    Description = "Its cell structure is similar to water molecules. It will melt away and become invisible in water.",
                    ImagePath="vaporeon.jpg",
                    UnitPrice = 54.50,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venomoth",
                    Description = "The powdery scales on its wings are hard to remove. They also contain poison that leaks out on contact.",
                    ImagePath="venomoth.jpg",
                    UnitPrice = 23.00,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venonat",
                    Description = "Its large eyes act as radars. In a bright place, you can see that they are clusters of many tiny eyes.",
                    ImagePath="venonat.jpg",
                    UnitPrice = 13.00,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "venusaur",
                    Description = "The flower on its back catches the sun's rays. The sunlight is then absorbed and used for energy.",
                    ImagePath="venusaur.jpg",
                    UnitPrice = 62.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "victreebel",
                    Description = "Lures prey with the sweet aroma of honey. Swallowed whole, the prey is melted in a day, bones and all.",
                    ImagePath="victreebel.jpg",
                    UnitPrice = 19.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vileplume",
                    Description = "Flaps its broad flower petals to scatter its poisonous pollen. The flapping sound is very loud.",
                    ImagePath="vileplume.jpg",
                    UnitPrice = 65.50,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "voltorb",
                    Description = "It is said to camouflage itself as a Poké Ball. It will self-destruct with very little stimulus.",
                    ImagePath="voltorb.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "vulpix",
                    Description = "Both its fur and its tails are beautiful. As it grows, the tails split and form more tails.",
                    ImagePath="vulpix.jpg",
                    UnitPrice = 15.50,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "wartortle",
                    Description = "When tapped, this Pokémon will pull in its head, but its tail will still stick out a little bit.",
                    ImagePath="wartortle.jpg",
                    UnitPrice = 28.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weedle",
                    Description = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.",
                    ImagePath="weedle.jpg",
                    UnitPrice = 3.00,
                    CategoryID = 15
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weepinbell",
                    Description = "When hungry, it swallows anything that moves. Its hapless prey is melted inside by strong acids.",
                    ImagePath="weepinbell.jpg",
                    UnitPrice = 51.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "weezing",
                    Description = "It lives and grows by absorbing dust, germs and poison gases that are contained in toxic waste and garbage.",
                    ImagePath="weezing.jpg",
                    UnitPrice = 38.50,
                    CategoryID = 8
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "wigglytuff",
                    Description = "Its body is full of elasticity. By inhaling deeply, it can continue to inflate itself without limit.",
                    ImagePath="wigglytuff.jpg",
                    UnitPrice = 41.50,
                    CategoryID = 7
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "zapdos",
                    Description = "This legendary bird Pokémon is said to appear when the sky turns dark and lightning showers down.",
                    ImagePath="zapdos.jpg",
                    UnitPrice = 9999.99,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "zubat",
                    Description = "Emits ultrasonic cries while it flies. They act as a sonar used to check for objects in the way.",
                    ImagePath="zubat.jpg",
                    UnitPrice = 1.25,
                    CategoryID = 8
                }
            };
      return products;
    }
  }
}