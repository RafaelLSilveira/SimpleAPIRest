    using API.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace API.Data
    {
        public class ClientsDb : IEntityTypeConfiguration<Clients>
        {
            public void Configure(EntityTypeBuilder<Clients> builder)
            {
                builder.ToTable("clients");
                        
                builder.HasKey(x => x.Id);
                    
                builder.Property(x => x.TxId)
                    .HasColumnName("tx_id");

                builder.Property(x => x.IdentityCard)
                    .HasColumnName("identity_card");

                builder.Property(x => x.Name)
                    .HasColumnName("name");

                builder.Property(x => x.Phone)
                    .HasColumnName("phone");

                builder.Property(x => x.Email)
                    .HasColumnName("email");

                builder.Property(x => x.BirthDate)
                    .HasColumnName("birth_date");

                builder.Property(x => x.Created)
                    .HasColumnName("created");
            }
        }
    }