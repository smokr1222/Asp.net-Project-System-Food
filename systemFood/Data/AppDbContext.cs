
using systemFood.Models;

namespace systemFood.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }


        public DbSet<Product> Products                       { get; set; }
        public DbSet<Category> Category                      { get; set; }
        public DbSet<Orders> Orders                          { get; set; }
        public DbSet<OrderItems> OrderItems                  { get; set; }
        public DbSet<Discount> Discount                      { get; set; }
        public DbSet<Extras> Extras                          { get; set; }
        public DbSet<SelectExtrasProduct> selectExtrasProduc { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {






            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1,Name = "جميع الأصناف", Icon = "fas fa-border-all" },
                new Category {Id = 2,Name = "بيتزا", Icon = "fas fa-pizza-slice" },
                new Category {Id = 3,Name = "باستا", Icon = "fas fa-utensils" },
                new Category {Id = 4,Name = "وجبات سريعة", Icon = "fas fa-burger" },
                new Category {Id = 5,Name = "مشروبات", Icon = "fas fa-beer-mug-empty" },
                new Category {Id = 6,Name = "سلطات", Icon = "fas fa-salad" }
                
                );

            modelBuilder.Entity<Discount>().HasData(


               new Discount { Id=1,DescaondName="SUBER10",DescaondNumber=0.1},
               new Discount { Id=2,DescaondName="SUBER20",DescaondNumber= 0.2 },
               new Discount { Id=3,DescaondName="SUBER30",DescaondNumber= 0.3}

                );


            modelBuilder.Entity<Extras>().HasData(
              new Extras { Id = 1, Name = "جبنة", Price=500,CatogryId = 2 },
              new Extras { Id = 2, Name = "شطة", Price = 300, CatogryId = 2 },
              new Extras { Id = 3, Name = "كاتشب", Price = 700, CatogryId = 4 },
              new Extras { Id = 4, Name = "زبادي مع خيار ", Price = 900, CatogryId = 2 },
              new Extras { Id = 5, Name = "سلطة حاره", Price = 100, CatogryId = 2 },
              new Extras { Id = 6, Name = "ثلج مكعبات", Price = 100, CatogryId = 5 },
              new Extras { Id = 7, Name = "جبنة", Price = 100, CatogryId = 3 },
              new Extras { Id = 8, Name = "شراح ليمون", Price = 200, CatogryId = 5 }
            );



            modelBuilder.Entity<SelectExtrasProduct>()
        .HasOne(s => s.orderitems)
        .WithMany(o => o.selectExtra)
        .HasForeignKey(s => s.orderitemid)
        .OnDelete(DeleteBehavior.Restrict); // ❗️هذا يمنع المسارات المتعددة





            base.OnModelCreating(modelBuilder); 
        }


    }
}
