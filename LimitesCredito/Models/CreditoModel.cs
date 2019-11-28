namespace LimitesCredito.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CreditoModel : DbContext
    {
        public CreditoModel()
            : base("name=CreditoModelo")
        {
        }

        public virtual DbSet<LIMITES_CREDITOS_LIC> LIMITES_CREDITOS_LIC { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LIMITES_CREDITOS_LIC>()
                .Property(e => e.VLR_TOTAL_APROVACAO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LIMITES_CREDITOS_LIC>()
                .Property(e => e.PER_TAXA_OPERACAO)
                .HasPrecision(19, 10);

            modelBuilder.Entity<LIMITES_CREDITOS_LIC>()
                .Property(e => e.VLR_TARIFA_OPERACAO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LIMITES_CREDITOS_LIC>()
                .Property(e => e.VLR_TOTAL_DESCONTOS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LIMITES_CREDITOS_LIC>()
                .Property(e => e.VLR_LIQUIDO_APROVACAO)
                .HasPrecision(19, 4);
        }
    }
}
