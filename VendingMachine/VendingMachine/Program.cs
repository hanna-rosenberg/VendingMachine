var vendingMachine = new VendingMachine();
vendingMachine.Items = new List<Item>()
{
new Item("COCA-COLA", 33),
new Item("FANTA", 33),
new Item("SPRITE", 33),
new Item("PRINGLES", 25),
new Item("LOLLIPOP", 10),
new Item("CHEWING-GUM", 10),
new Item("SNICKERS", 20),
new Item("MARABOU", 20),
new Item("REFRESHERS", 33),
new Item("POPCORN", 25),
new Item("M&M", 18),
new Item("DORRITOS", 25),
};

var options = "";
var total = 40;

Console.WriteLine("Welcome to Fantastic Vending Machine!!");

while (options == "")
{
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.Write("Type SEE ITEMS, BUY NOW, VIEW CREDIT or LEAVE: ");

    options = Console.ReadLine();

    if (options == "SEE ITEMS")
    {

        foreach (Item item in vendingMachine.Items)
        {
            Console.WriteLine(item.Name + " - " + item.Price + ":-");
        }

        Console.WriteLine();
        Console.Write("Type BUY NOW or LEAVE: ");
        options = Console.ReadLine();

        if (options == "BUY NOW")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();

            options = Console.ReadLine();


            foreach (Item item in vendingMachine.Items)
            {

                if (options == item.Name)
                {
                    if (total < item.Price)
                    {
                        Console.WriteLine();
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine(" :( YOU DONT HAVE ENOUGH MONEY :( ");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine();
                        options = "";
                    }
                    else
                    {
                        total = total - item.Price;
                        Console.WriteLine();
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine($"YOU BOUGHT {item.Name} WHICH COSTS {item.Price} SEK. YOU HAVE {total} SEK LEFT ");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine();


                        System.Threading.Thread.Sleep(2000);
                        options = "";
                    }
                }
            }


        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(":( I'm sorry, that's not a valid option :( ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
            options = "";
        }




        if (options == "LEAVE")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(" :) WELCOME BACK :) ");
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            options = "";
            Console.Clear();
        }

        //else
        //{
        //    Console.WriteLine("I'm sorry, that's not a valid option");
        //    options = "";
        //}

    }
    else if (options == "BUY NOW")
    {

        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine();


        options = Console.ReadLine();

        foreach (Item item in vendingMachine.Items)
        {

            if (options == item.Name)
            {
                if (total < item.Price)
                {
                    Console.WriteLine();
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("YOU DON'T HAVE ENOUGH MONEY, PLEASE TRY AGAIN");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
                    options = "";
                }
                else
                {
                    total = total - item.Price;
                    Console.WriteLine();
                    Console.WriteLine($"You bought a {item.Name} which costs {item.Price} SEK. You now have {total} SEK left ");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(2000);
                    options = "";
                }
            }
        }

    }

    else if (options == "LEAVE")
    {

        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - -");
        Console.WriteLine(" :) WELCOME BACK :) ");
        Console.WriteLine("- - - - - - - - - - -");
        Console.WriteLine();
        System.Threading.Thread.Sleep(2000);
        options = "";
        Console.Clear();
    }



    else if (options == "VIEW CREDIT")
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine($" :) YOUR CREDIT IS: {total} SEK :) ");
        Console.WriteLine("- - - - - - - - - - - - - - - -");
       
        options = "";
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine(":( I'm sorry, that's not a valid option :( ");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine();
        options = "";
      

    }
}

//Console.WriteLine();
//Console.WriteLine($"You have selected {options}, your total is ${total}:-");