using System;
using System.Linq;
using ef;
using ef.Models.App;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.Posts.Any())
            return;

        var Authors = new Author[]
        {
            new Author{FirstName="Jan", LastName="Kowalski", Created = DateTime.Now},
            new Author{FirstName="Krzysztof", LastName="Nowak", Created = DateTime.Parse("2008-06-17")},
            new Author{FirstName="Marzena", LastName="Grabowska", Created = DateTime.Parse("2015-09-13")},
            new Author{FirstName="Marcin", LastName="Caliński", Created = DateTime.Parse("1989-12-26")},
        };

        foreach (Author a in Authors)
        {
            context.Authors.Add(a);
        }
        context.SaveChanges();


        var Posts = new Post[]
        {
            new Post{Content="Pierwszy post który autor napisał.", AuthorId=1,Created=DateTime.Parse("2005-09-01")},
            new Post{Content="Drugi post który autor napisał.", AuthorId=1, Created=DateTime.Parse("2015-09-01")},
            new Post{Content="Trzeci post który autor napisał.", AuthorId=2,Created=DateTime.UtcNow},
            new Post{Content="Czwarty post który autor napisał.", AuthorId=3,Created=DateTime.Parse("2005-09-01")},
            new Post{Content="Piaty post który autor napisał.", AuthorId=3, Created=DateTime.Parse("2015-09-01")},
            new Post{Content="Szosty post który autor napisał.", AuthorId=3,Created=DateTime.UtcNow},
            new Post{Content="Setny post który autor napisał.", AuthorId=4,Created=DateTime.Parse("2005-09-01")},
            new Post{Content="Tysieczny post który autor napisał.", AuthorId=4, Created=DateTime.Parse("2015-09-01")},
            new Post{Content="Milionowy post który autor napisał.", AuthorId=4,Created=DateTime.UtcNow},
        };
        foreach (Post p in Posts)
        {
            context.Posts.Add(p);
        }
        context.SaveChanges();
    }
}