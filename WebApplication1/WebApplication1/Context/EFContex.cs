using System.Data.Entity;

namespace WebApplication1.Context
{
    public class EFContex : DbContext
    {
        public EFContex() : base("Asp_Net_MVC_CS") { }
    }
}
