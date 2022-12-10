
using BcProje.Business.Abstract;
using BcProje.Business.Conctrete;
using BcProje.DataAccess.Abstract;
using BcProje.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IEmployeeService, EmployeeManager>();
builder.Services.AddTransient<IEmployeeDal, EmployeeDal>();
builder.Services.AddTransient<ICustomerService, CustomerManager>();
builder.Services.AddTransient<ICustomerDal, CustomerDal>();
builder.Services.AddTransient<IProductDal, ProductDal>();
builder.Services.AddTransient<IProductService, ProductManager>();
builder.Services.AddTransient<ICustomerProductDal, CustomerProductDal>();
builder.Services.AddTransient<ICustomerProductService, CustomerProductManager>();
builder.Services.AddTransient<IVisitDal, VisitDal>();
builder.Services.AddTransient<IVisitService, VisitManager>();
builder.Services.AddTransient<ISaleService, SaleManager>();
builder.Services.AddTransient<ISaleDal, SaleDal>();
builder.Services.AddTransient<IReportDal, ReportDal>();
builder.Services.AddTransient<IReportService, ReportManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
 
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
