using System.Diagnostics;
using System.Drawing;

namespace group1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chairs MyChairs = new Chairs("Red", 33000, 90, 4, "Wood", "Leather");
            Tables MyTables = new Tables("Metallic Grey", 8000, 85, 4, "Aluminium", "Round");
            LoungeChair MyLoungeChair = new LoungeChair("Brown", 20000, 95, 4, "Wood", "Linen", "Massage");
            KitchenTable MyKitchenTable = new KitchenTable("White", 12000, 85, 1, "Oak", "Round", "Glass");

            Console.WriteLine("The Red Chair");
            MyChairs.CreateChair();

            Console.WriteLine("The Round Table");
            MyTables.CreateTable();

            Console.WriteLine("The Lounge Chair");
            MyLoungeChair.CreateChair();

            Console.WriteLine("The KitchenTable");
            MyKitchenTable.CreateTable();
        }
    }
}