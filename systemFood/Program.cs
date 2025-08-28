

using systemFood.UnitofWork;
using systemFood.UnitofWork.Interface;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IMineFoodServices, MineFoodService>();
builder.Services.AddTransient<IDescaondService, DescaondService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IExtraServices, ExtraServices>();
builder.Services.AddTransient<IOrderItemSevice, OrderItemSevice>();
builder.Services.AddTransient<IHistorysServices, HistorysServices>();
builder.Services.AddTransient(typeof( IGenericRepository<>),typeof( GenericRepository<>));
builder.Services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddTransient(typeof(IOrderItemRepository), typeof(OrderItemRepository));
builder.Services.AddTransient(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddTransient(typeof(IExtraRepostory), typeof(ExtraRepostory));
builder.Services.AddTransient(typeof(IHistorysRepositoy), typeof(HistorysRepositoy));




builder.Services.AddScoped(typeof(IUnitOfWorkServices), typeof(UnitOfWorkServices));





builder.Services.AddSession(); // <-- ÖÑæÑí


var Connect = builder.Configuration.GetConnectionString("MyConnecttion");

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(Connect));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession(); // <-- ÖÑæÑí

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
