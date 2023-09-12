using BlogProject.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                Id = 1,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+905552221905",
                FirstName = "Erden",
                LastName = "Timur",
                About = "Sistemin en yetkili admini.",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Path = "user-images/kullanici.png"

            };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            var author1 = new AppUser
            {
                Id = 2,
                UserName = "umut@gmail.com",
                NormalizedUserName = "UMUT@GMAIL.COM",
                Email = "umut@gmail.com",
                NormalizedEmail = "UMUT@GMAIL.COM",
                PhoneNumber = "+905552221923",
                FirstName = "Umut",
                LastName = "Öncel",
                About = "Sitenin kıdemli yazar kadrosuna dahil.",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Path = "user-images/kullanici.png"
            };
            author1.PasswordHash = CreatePasswordHash(author1, "123456");

            var author2 = new AppUser
            {
                Id = 3,
                UserName = "eren@gmail.com",
                NormalizedUserName = "EREN@GMAIL.COM",
                Email = "eren@gmail.com",
                NormalizedEmail = "EREN@GMAIL.COM",
                PhoneNumber = "+905552221967",
                FirstName = "Eren",
                LastName = "Kartal",
                About = "Sitenin kıdemli yazar kadrosuna dahil.",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Path = "user-images/kullanici.png"
            };
            author2.PasswordHash = CreatePasswordHash(author2, "123456");

            var author3 = new AppUser
            {
                Id = 4,
                UserName = "furkan@gmail.com",
                NormalizedUserName = "FURKAN@GMAIL.COM",
                Email = "furkan@gmail.com",
                NormalizedEmail = "FURKAN@GMAIL.COM",
                PhoneNumber = "+905552221934",
                FirstName = "Furkan",
                LastName = "Kahveci",
                About = "Sitenin kıdemli yazar kadrosuna dahil.",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Path = "user-images/kullanici.png"
            };
            author3.PasswordHash = CreatePasswordHash(author3, "123456");

            builder.HasData(admin, author1, author2, author3);
        }

        private string CreatePasswordHash(AppUser appUser, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(appUser, password);
        }
    }
}
