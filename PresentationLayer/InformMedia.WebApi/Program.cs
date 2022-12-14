using InformMedia.Repository.Contracts.UnitOfWork;
using InformMedia.Repository.Implementation;
using InformMedia.Repository.Implementation.UnitOfWork;
using InformMedia.WebApi.Startup;
using Microsoft.AspNetCore.Mvc;

namespace InformMedia.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<InformMediaContext>();
            builder.Services.AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();
            DataAccessLayerStartup.RegisterServices(builder);
            BusinessLayerStartup.RegisterServices(builder);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApiVersioning(option =>
            {
                option.DefaultApiVersion = new ApiVersion(1, 0);
                option.AssumeDefaultVersionWhenUnspecified = true;
            });
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}