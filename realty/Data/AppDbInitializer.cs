using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using properties.Controllers.Data;
using realty.Data.Model;
using System;
using System.Linq;

namespace realty.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppdbContext>();

                if (!context.pron.Any())
                {
                    context.pron.AddRange(new pronat()
                    {
                        PropertyType="For Sale",
                        PropertyCategory="Apartment",
                        City="Tirana",
                        Zone="DonBosko",
                        Bedroom=2,
                        Area=94,
                        Price=108000
                        
                    });

                }

            
                context.SaveChanges();

            }
        }
    }
}
