using AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Infrastructure.EntityConfiguration
{
    public class PersonaEjercicioEntityTypeConfiguration : IEntityTypeConfiguration<PersonaEjercicio>
    {
        public void Configure(EntityTypeBuilder<PersonaEjercicio> builder)
        {
            builder.ToTable("PersonaEjercicio", AppDbContext.DEFAULT_SCHEMA);
            builder.HasKey(o => o.PersonId);

            builder
               .Property<int>("PersonId")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired();

            builder
               .Property<string>("Name")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired();

            builder
               .Property<string>("LastName")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired();

            builder
               .Property<string?>("FirstName")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired(false);

            builder
               .Property<int?>("Age")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired(false);
        }
    }
}
