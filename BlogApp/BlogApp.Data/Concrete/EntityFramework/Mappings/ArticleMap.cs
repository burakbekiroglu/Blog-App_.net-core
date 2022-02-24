﻿
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
   public  class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            //builder.HasData(new Article
            //{
            //    Id = 1,
            //    CategoryId = 1,
            //    Title = "C# 9.0 ve .NET5 Yenilikleri",
            //    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı " +
            //    "bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak " +
            //    "karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl " +
            //    "boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. " +
            //    "1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus " +
            //    "PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //    Thumbnail = "Default.jpg",
            //    SeoDescription = "C# 9.0 ve .NET5 Yenilikleri",
            //    SeoTags = "C^, .net, .net core",
            //    SeoAuthor = "Burak Bekiroglu",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C# 9.0 ve .NET5 Yenilikleri",
            //    UserId = 1,
            //    ViewsCount = 100,
            //    CommentCount=1

            //},
            //new Article
            //{
            //    Id = 2,
            //    CategoryId = 2,
            //    Title = "C++ 11 ve 19 Yenilikleri",
            //    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı " +
            //    "bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak " +
            //    "karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl " +
            //    "boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. " +
            //    "1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus " +
            //    "PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //    Thumbnail = "Default.jpg",
            //    SeoDescription = "C++ 11 ve 19 Yenilikleri",
            //    SeoTags = "c++",
            //    SeoAuthor = "Burak Bekiroglu",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C++ 11 ve 19 Yenilikleri",
            //    UserId = 1,
            //     ViewsCount = 150,
            //    CommentCount = 1
            //},
            // new Article
            // {
            //     Id = 3,
            //     CategoryId = 3,
            //     Title = "JavaScript Yenilikleri",
            //     Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı " +
            //    "bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak " +
            //    "karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl " +
            //    "boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. " +
            //    "1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus " +
            //    "PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //     Thumbnail = "Default.jpg",
            //     SeoDescription = "JavaScript Yenilikleri",
            //     SeoTags = "JavaScript Yenilikleri",
            //     SeoAuthor = "Burak Bekiroglu",
            //     Date = DateTime.Now,
            //     IsActive = true,
            //     IsDeleted = false,
            //     CreatedByName = "InitialCreate",
            //     CreatedDate = DateTime.Now,
            //     ModifiedByName = "InitialCreate",
            //     ModifiedDate = DateTime.Now,
            //     Note = "JavaScript Yenilikleri",
            //     UserId = 1,
            //     ViewsCount = 2500,
            //     CommentCount = 1
            // });
            
        }
    }
}
