namespace TextCorrector_Product
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Product product = null;
            Console.WriteLine("Enter 1 for first task and 2 for second.Enter something else programm to stop programm");
            string option;
            do
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter your text");
                        string CorrectedText = TextCorrector(Console.ReadLine());
                        Console.WriteLine(CorrectedText);
                        break;
                    case "2":
                        string option2;
                        do
                        {
                            Console.WriteLine("Enter 1 for new product, 2 for getting info about product, 3 for sale");
                            option2 = Console.ReadLine();
                            switch (option2)
                            {

                                case "1":
                                    Console.WriteLine("Enter Brand Name , Model, Price, Cost, Count");
                                    string brandName = Console.ReadLine();
                                    string model = Console.ReadLine();
                                    int price = Convert.ToInt32(Console.ReadLine());
                                    int cost = Convert.ToInt32(Console.ReadLine());
                                    int count = Convert.ToInt32(Console.ReadLine());
                                    product = new Product(brandName, model, price, cost, count);
                                    break;
                                case "2":
                                    if (product == null)
                                    {
                                        Console.WriteLine("No product was added, please enter 1 and add some item");
                                    }
                                    else
                                    {
                                        product.GetInfo();
                                    }
                                    break;
                                case "3":
                                    if (product == null)
                                    {
                                        Console.WriteLine("No product was added, please enter 1 and add some item");
                                    }
                                    else
                                    {
                                        product.Sale();
                                    }
                                    break;
                            }
                        } while (option2 == "1" || option2 == "2" || option2 == "3");
                        Console.WriteLine("Task two ended succsessfully");


                        break;
                }
            }
            while (option == "1" || option == "2");
            Console.WriteLine("Programm ended successfully");
        }

        static string TextCorrector(string text)
        {
            text = text.Trim();
            if (text.Length == 0)
            {
                text = "Nothing were texted";
            }
            string newText = "";
            bool isSpace = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (!isSpace)
                    {
                        newText += text[i];
                    }
                    isSpace = true;
                }
                else
                {
                    isSpace = false;
                    newText += text[i];
                }

            }

            string[] words = newText.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            text = String.Join(" ", words);
            return text;
        }



    }
}
