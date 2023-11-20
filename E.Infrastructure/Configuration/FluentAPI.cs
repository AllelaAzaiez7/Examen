
using E.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{ 

    public class FluentAPI : IEntityTypeConfiguration<Concert>

    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
                builder.HasKey(e => new { e.ArtisteFK, e.FestivalFK }); 
                builder.HasOne(e=>e.Artiste.WithMany(e=>e.Concert).HasForeignKey(e=>e.ArtisteFK));
            builder.HasOne(e => e.Festival).WithMany(e => e.Concert).HasForeignKey(e => e.FestivalFK);
        
          builder.HasKey(e => new { e.ArtisteFK, e.FestivalFK ,e.DateConcert});




        }
    }
}
