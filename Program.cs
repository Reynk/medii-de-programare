using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TruckManagement.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy =>
   policy.RequireRole("Admin"));
});
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("DriverPolicy", policy =>
   policy.RequireRole("User"));
});


// Add services to the container.
builder.Services.AddRazorPages((options =>
{
    options.Conventions.AuthorizeFolder("/Deliveries");
    options.Conventions.AuthorizeFolder("/Users", "AdminPolicy");
    options.Conventions.AuthorizeFolder("/Statuses", "AdminPolicy");
    options.Conventions.AllowAnonymousToPage("/Deliveries/Index");
    options.Conventions.AllowAnonymousToPage("/Deliveries/Details");
    options.Conventions.AllowAnonymousToPage("/Deliveries/EditStatus");
}));
builder.Services.AddDbContext<TruckManagementDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TruckManagementDBContext") ?? throw new InvalidOperationException("Connection string 'TruckManagementDBContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityContext>();

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TruckManagementDBContext") ?? throw new InvalidOperationException("Connectionstring 'TruckManagementDBContext' not found.")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
