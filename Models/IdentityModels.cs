using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FinalProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Brand> tbl_Brand { get; set; }
        public DbSet<Category> tbl_Category { get; set; }
        public DbSet<Subcategory> tbl_Subcategory { get; set; }
        public DbSet<Wishlist> tbl_Wishlist { get; set; }
        
        public DbSet<User> tbl_User { get; set; }


        public DbSet<Product> tbl_Product { get; set; }
        public DbSet<Order> tbl_Order { get; set; }
        public DbSet<OrderDetail> tbl_OrderDetail { get; set; }

        public DbSet<Shipping> tbl_Shipping { get; set; }
        public DbSet<Reviews> tbl_Reviews { get; set; }
        public DbSet<Payment> tbl_Payment { get; set; }
        public DbSet<PaymentType> tbl_PaymentType { get; set; }
        public DbSet<Vouchers> tbl_Vouchers { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}