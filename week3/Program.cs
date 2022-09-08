using System;

public class Program {
    
    public static string InputName() {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }

    public static string InputNumber() {
        Console.Write("Please input Number: ");
        return Console.ReadLine();
    }

    public static string InputOwnerName() {
        Console.Write("Please input Owner Name: ");
        return Console.ReadLine();
    }

    public static string InputRegisteredValue() {
        Console.Write("Please input Registered Value: ");
        return (Console.ReadLine());
    }
     
     public static int ConvertValueToint(string value) {
        if (int.TryParse(value, out int number))
        {
            return number;
        }
        throw new Exception("Please input your Number!!.");
    }  

    public static string InputMoney() {
        Console.Write("please input money : ");

        return Console.ReadLine();
    }

    public static double ConvertStringToDouble(string value) {
        if(double.TryParse(value, out double number)) {
        return number;
        }

        throw new Exception("Please input your Number!!.");
    }

    public static void Main(string[] args) {
        string Name = InputName();
        string Id = InputNumber();
        string Owner = InputOwnerName();
        string TRegisValue = InputRegisteredValue();
        int RegisValue = ConvertValueToint(TRegisValue);
        Shopinfo info = new Shopinfo(Name, Id, Owner, RegisValue);
        info.PrintShopInformation();

        int OneThousandBath = 0;
        int FiveHundredBath = 0;
        int OneHundredBath = 0;
        int FiftyBath = 0;
        int TwentyBath = 0;
        int TenBath = 0;
        int FiveBath = 0;
        int TwoBath = 0;
        int OneBath = 0;
        int FiftySatang = 0;
        int TwentyFiveSatang = 0;

        string MoneyText = InputMoney();
        double MoneyNumber = ConvertStringToDouble(MoneyText);
        MoneyExchange.Calculate(MoneyNumber,ref OneThousandBath,ref FiveHundredBath,ref OneHundredBath,ref FiftyBath,ref TwentyBath,ref TenBath,ref FiveBath,ref TwoBath,ref OneBath,ref FiftySatang,ref TwentyFiveSatang);
        MoneyExchange.PrintInformation(OneThousandBath, FiveHundredBath, OneHundredBath, FiftyBath, TwentyBath, TenBath, FiveBath, TwoBath, OneBath, FiftySatang, TwentyFiveSatang);

     }
}