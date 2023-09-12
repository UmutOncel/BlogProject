using BlogProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.FileName)
                .IsRequired();

            builder.Property(x => x.FileType)
                .IsRequired();

            builder.HasData(
                new Image { Id = 1, FileName = "article-images/OOP.png", FileType = "png", CreatedBy = "Umut Öncel", CreatedDate = DateTime.Now, IsDeleted = false },
                new Image { Id = 2, FileName = "article-images/MVC.jpg", FileType = "jpg", CreatedBy = "Eren Kartal", CreatedDate = DateTime.Now, IsDeleted = false },
                new Image { Id = 3, FileName = "article-images/EF.png", FileType = "png", CreatedBy = "Furkan Kahveci", CreatedDate = DateTime.Now, IsDeleted = false }
                );
        }
    }
}
