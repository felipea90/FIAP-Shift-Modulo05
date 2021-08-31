using AutoMapper;
using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Fiap.Web.AspNet.Repository.Interface;
using Fiap.Web.AspNet.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("databaseUrl")));

            var connectionString = Configuration.GetConnectionString("databaseUrl");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            var mapperConfig = new AutoMapper.MapperConfiguration(
                c => 
                {
                    // Passar ORIGEM -> DESTINO no CreateMap

                    c.CreateMap<RepresentanteViewModel, RepresentanteModel>();
                    c.CreateMap<RepresentanteModel, RepresentanteViewModel>()
                    .ForMember(v => v.Clientes, m => m.MapFrom(x => x.Clientes));

                    c.CreateMap<IList<RepresentanteModel>, IList<RepresentanteViewModel>>();
                    c.CreateMap<IList<RepresentanteViewModel>, IList<RepresentanteModel>>();

                    c.CreateMap<ClienteViewModel, ClienteModel>();
                    c.CreateMap<ClienteModel, ClienteViewModel>();

                    c.CreateMap<ProdutoLojaViewModel, ProdutoModel>();
                    c.CreateMap<ProdutoModel, ProdutoLojaViewModel>();
                });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ILojaRepository, LojaRepository>();
            services.AddScoped<IRepresentanteRepository, RepresentanteRepository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
