using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProjectUIMockUp
{
    class Db{}

    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string OrderContents { get; set; }
        public string OrderQuantities { get; set; }
        public int UserID { get; set; }
       // [ForeignKey("UserID")]
      //  public virtual User User { get; set; }
        public OrderType OrderType { get; set; }
    }

    public class AutoPart
    {
        
        public int AutoPartID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class AutoPartsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<AutoPart> Parts { get; set; }
    }


}
