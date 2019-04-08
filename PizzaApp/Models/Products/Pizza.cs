using Services.Abstract;

namespace Models
{
    public class Pizza 
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public bool IsExists { get; set; }
            public string Composition { get; set; }
            public bool ThinDough { get; set; }
            public Pizza() { }
            public Pizza(string name,int price, bool isExist, string composition, bool thindough) 
            {
            Name = name;
            Price = price;
            IsExists = isExist;
            Composition = composition;
            ThinDough = thindough;
            } 
    }
}
