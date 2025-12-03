
Random rng = new Random();

        Console.WriteLine("Velkommen til terningespillet");

        Console.Write("Hvor mange terninger vil du slå? ");
        string? input = Console.ReadLine();
        int antalTerninger;
        while (!int.TryParse(input, out antalTerninger) || antalTerninger <= 0)
        {
            Console.Write("Indtast et gyldigt positivt tal: ");
            input = Console.ReadLine();
        }

        Console.Write("Hvor mange sider skal hver terning have? ");
        string? siderInput = Console.ReadLine();
        int antalSider;
        while (!int.TryParse(siderInput, out antalSider) || antalSider <= 0)
        {
            Console.Write("Indtast et gyldigt positivt tal for sider: ");
            siderInput = Console.ReadLine();
        }

        Dice dice = new Dice(antalSider);

        Console.WriteLine("Tryk Enter for at player 1 slår...");
        Console.ReadLine();

        int sum1 = 0;
        for (int i = 0; i < antalTerninger; i++)
        {
            int slag = dice.Throw();
            Console.WriteLine($"Player 1 - Terning {i + 1}: {slag}");
            sum1 += slag;
        }
        Console.WriteLine($"Player 1 Total: {sum1}");


        Console.WriteLine("Tryk ENTER for at player 2 slår...");
        Console.ReadLine();

        int sum2 = 0;
        for (int i = 0; i < antalTerninger; i++)
        {
            int slag = dice.Throw(); //objekt metode istedet  
            Console.WriteLine($"Player 2 - Terning {i + 1}: {slag}");
            sum2 += slag;
        }

        Console.WriteLine($"Player 2 Total: {sum2}");

        Console.WriteLine("Resultat:");
        if (sum1 > sum2)
        {
            Console.WriteLine("Player 1 Vinder!");
        }
        else if (sum2 > sum1)
        {
            Console.WriteLine("Player 2 Vinder!");
        }
        else
        {
            Console.WriteLine("Det blev uafgjort!");
        }

        Console.WriteLine("Tak for spillet!");
        Console.ReadLine();