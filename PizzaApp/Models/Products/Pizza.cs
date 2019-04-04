using Services.Abstract;

namespace Models
{
    public class Pizza : Product
    {
            public string Composition { get; set; }
            public bool ThinDough { get; set; }
    }
}
