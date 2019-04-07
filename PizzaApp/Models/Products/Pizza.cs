using Services.Abstract;

namespace Models
{
    public class Pizza : Product
    {
            public string Composition { get; set; }
            public bool ThinDough { get; set; }
            public Pizza(string name,int price, bool isExist, string composition, bool thindough ) : base(name, price,isExist)
            {
                Composition = composition;
                ThinDough = thindough;
            } 
    }
}
