    using API.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace API.Data
    {
        public class HealthPlansDb : IEntityTypeConfiguration<HealthPlans>
        {
            public void Configure(EntityTypeBuilder<HealthPlans> builder)
            {
                builder.ToTable("health_plans");
                        
                builder.HasKey(x => x.Id);
                    
                builder.Property(x => x.ClientId)
                    .HasColumnName("client_id");
                
                builder.HasIndex(x => x.ClientId)
                    .HasDatabaseName("client_id");

                builder.Property(x => x.Title)
                    .HasColumnName("title");

                builder.Property(x => x.AllowsLegalPerson)
                    .HasColumnName("allows_legal_person");

                builder.Property(x => x.BeginningDate)
                    .HasColumnName("beginning_date");

                builder.Property(x => x.EndingDate)
                    .HasColumnName("ending_date");

                builder.Property(x => x.Created)
                    .HasColumnName("created");

                builder.HasOne(x => x.Client)
                    .WithMany(x => x.HealthPlans)
                    .HasForeignKey(x => x.ClientId);
            }
        }
    }