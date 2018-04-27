using BlogWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AutoMapper;
using BlogWebAPI.ViewModels;
using BlogWebAPI.Domain;
using BlogWebAPI.Services;
using NLog.Extensions.Logging;

namespace BlogWebAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var config = Configuration.GetConnectionString("BlogConnection");
            // Add framework services.
            services.AddDbContext<BlogContext>(options=>options.UseSqlServer(config));

            services.AddTransient<BlogContextSeedData>();

            services.AddScoped<IBlogPostRepository, BlogPostRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddMvc();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            BlogContextSeedData seeder)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ContactViewModel, Contact>().ReverseMap();
                config.CreateMap<BlogPostViewModel, BlogPost>().ReverseMap();
                config.CreateMap<PostsViewModel, BlogPost>().ReverseMap();
                config.CreateMap<AuthorViewModel, Author>().ReverseMap();
                config.CreateMap<AuthorWithoutPost, Author>().ReverseMap();
                config.CreateMap<CategoryViewModel, Category>().ReverseMap();
                config.CreateMap<TagViewModel, Tag>().ReverseMap();
            });

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddNLog();

            app.UseCors("CorsPolicy");

            app.UseMvc();

            seeder.EnsureSeedData().Wait();
        }
    }
}
