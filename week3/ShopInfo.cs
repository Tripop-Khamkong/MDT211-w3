public class Shopinfo
{
    private string Name = "";
    private string Id = "";
    private string Owner = "";
    private int RegisValue;

    public Shopinfo(string Name,string Id,string Owner,int RegisValue){
    this.Name = Name;
    this.Id = Id;
    this.Owner = Owner;
    this.RegisValue = RegisValue;    
    }

    public void PrintShopInformation() {
        Console.WriteLine();
        Console.WriteLine("---------- Shop Information ----------");
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Number: {0}", Id);
        Console.WriteLine("Owner Name: {0}", Owner);
        Console.WriteLine("Registered Value: {0}", RegisValue);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }  
}