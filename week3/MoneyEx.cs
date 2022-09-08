public class MoneyExchange
{
  public static void Calculate(double InputMoney, 
  ref int OneThousandBath,
  ref int FiveHundredBath,
  ref int OneHundredBath,
  ref int FiftyBath,
  ref int TwentyBath,
  ref int TenBath,
  ref int FiveBath,
  ref int TwoBath,
  ref int OneBath,
  ref int FiftySatang,
  ref int TwentyFiveSatang) 
  {
        while(InputMoney != 0)
         {
            if(InputMoney >= 1000) {
                InputMoney -= 1000;
                OneThousandBath += 1;
            }
            else if (InputMoney >= 500) {
                InputMoney -= 500;
                FiveHundredBath += 1;
            }
            else if (InputMoney >= 100) {
                InputMoney -= 100;
                OneHundredBath += 1;
            }
            else if (InputMoney >= 50 ) {
                InputMoney -= 50;
                FiftyBath += 1;
            }
            else if (InputMoney >= 20) {
                InputMoney -= 20;
                TwentyBath += 1;
            }
            else if (InputMoney >= 10) {
                InputMoney -= 10;
                TenBath += 1;
            }
            else if (InputMoney >= 5) {
                InputMoney -= 5;
                FiveBath += 1;
            }
            else if (InputMoney >= 2) {
                InputMoney -= 2;
                TwoBath += 1;
            }
            else if (InputMoney >= 1) {
                InputMoney -= 1;
                OneBath += 1;
            }
            else if (InputMoney >= 0.50) {
                InputMoney -= 0.50;
                FiftySatang += 1;
            }
            else if (InputMoney >= 0.25) {
                InputMoney -= 0.25;
                TwentyFiveSatang += 1;
            }
        }
    } 
    public static void PrintInformation(int OneThousandBath,
    int FiveHundredBath,
    int OneHundredBath,
    int FiftyBath, 
    int TwentyBath,
    int TenBath,
    int FiveBath,
    int TwoBath, 
    int OneBath,
    int FiftySatang,
    int TwentyFiveSatang) 
    {
        Console.WriteLine("1000 : {0}",OneThousandBath);
        Console.WriteLine("500  : {0}",FiveHundredBath);
        Console.WriteLine("100  : {0}",OneHundredBath);
        Console.WriteLine("50   : {0}",FiftyBath);
        Console.WriteLine("20   : {0}",TwentyBath);
        Console.WriteLine("10   : {0}",TenBath);
        Console.WriteLine("5    : {0}",FiveBath);
        Console.WriteLine("2    : {0}",TwoBath);
        Console.WriteLine("1    : {0}",OneBath);
        Console.WriteLine("0.5  : {0}",FiftySatang);
        Console.WriteLine("0.25 : {0}",TwentyFiveSatang);
    } 
}