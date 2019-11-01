using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }


        public DbSet<Park> Parks { get; set; }
        public DbSet<User> Users {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Park>()
                .HasData(
                new Park 
                { 
                ParkId = 1,
                Name = "Yellowstone National Park", 
                State = "Wyoming", 
                Miles = 882 
                },

                new Park 
                { 
                ParkId = 2,
                Name = "Zion National Park", 
                State = "Utah", 
                Miles = 1070 
                },

                new Park 
                { 
                ParkId = 3,
                Name = "Yosemite National Park", 
                State = "California", 
                Miles = 722 
                },

                new Park 
                { 
                ParkId = 4,
                Name = "Acadia National Park", 
                State = "Maine", 
                Miles = 3360 
                },

                new Park 
                { 
                ParkId = 5,
                Name = "Grand Teton National Park", 
                State = "Wyoming", 
                Miles = 819 
                },

                new Park 
                { 
                ParkId = 6,
                Name = "Arches National Park", 
                State = "Utah", 
                Miles = 991 
                },

                new Park 
                { 
                ParkId = 7,
                Name = "Joshua Tree National Park", 
                State = "California", 
                Miles = 1096 
                },

                new Park 
                { 
                ParkId = 8,
                Name = "Sequoia National Park", 
                State = "California", 
                Miles = 829 
                },

                new Park 
                {
                ParkId = 9,
                Name = "Glacier National Park", 
                State = "Montana", 
                Miles = 647 
                },

                new Park
                {                 
                ParkId = 10,
                Name = "Capitol Reef National Park", 
                State = "Utah", 
                Miles = 987 
                },

                new Park
                {                 
                ParkId = 11,
                Name = "Badlands National Park", 
                State = "South Dakota", 
                Miles = 1254 
                },

                new Park
                {                 
                ParkId = 12,
                Name = "Great Sand Dunes", 
                State = "Colorado", 
                Miles = 1306
                },

                new Park
                {                 
                ParkId = 13,
                Name = "Mount Rainer National Park", 
                State = "Washington", 
                Miles = 136 
                },

                new Park
                {                 
                ParkId = 14,
                Name = "Dry Tortugas National Park", 
                State = "Florida", 
                Miles = 3484 
                }


                );
        }
    }
}