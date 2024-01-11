using System.Globalization;

//DateTime today = DateTime.Now;

////Console.WriteLine(today.ToString("a"));

//Console.Write("My birthday is ");
////DateTime birthday = DateTime.Parse("6/29/1991");
//DateTime birthday = DateTime.ParseExact("29/6/1991","d/M/yyyy",CultureInfo.DefaultThreadCurrentCulture);
//Console.WriteLine(birthday.ToString());


//DateOnly opensAt = DateOnly.Parse("6/29/91");
//TimeOnly wakeUp = TimeOnly.Parse("7:15");



//Console.Write(opensAt);
//Console.Write(" ");
//Console.Write(wakeUp);
//Console.WriteLine("");

//Console.WriteLine($"Best Buy opens on {opensAt} at {wakeUp}.");

        DateTime today = DateTime.Now;
        for(int i = 0; i <30; i++)
        {


            DateTime future = today.AddDays(i);

            Console.WriteLine(future.ToString());

        }
