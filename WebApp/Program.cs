using LogicaAplicacion.CasosUso.Socios;
using LogicaConexion.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); //agregado
builder.Services.AddDistributedMemoryCache(); //codigo agregado
builder.Services.AddSession(options =>
{
    //options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}); // codigo agregado



//Logica Conexion Context
builder.Services.AddDbContext<ClubContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("clubConnection"))
);


//Logica Conexion Repositorios
builder.Services.AddScoped<RepositorioSocio, RepositorioSocio>();
builder.Services.AddScoped<RepositorioAdministrador, RepositorioAdministrador>();

//Logica Aplicacion
//Socio
builder.Services.AddScoped<AltaSocio, AltaSocio>();

//Administrador






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



app.UseSession(); //codigo agregado para sesiones
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
