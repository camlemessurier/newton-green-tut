using System;
using Microsoft.EntityFrameworkCore;

namespace newton_green_tut.Models
{
    public class DonationDBContext:DbContext
    {

        public DonationDBContext(DbContextOptions<DonationDBContext> options):base(options)
        {

        }

    public DbSet<DCandidate> DCandidates { get; set; }

}
}
