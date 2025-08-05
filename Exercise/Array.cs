string[] fraudulentOrderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (var item in fraudulentOrderIds)
{
    if (item == "B")
    { 
        System.Console.WriteLine(item);
    }
}
