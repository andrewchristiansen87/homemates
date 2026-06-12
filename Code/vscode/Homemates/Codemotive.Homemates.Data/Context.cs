using Microsoft.EntityFrameworkCore;

namespace Codemotive.Homemates.Data;

public class Context : DbContext {

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Household>();
    }

}
