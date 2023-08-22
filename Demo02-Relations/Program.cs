// RELATION ONE TO MANY

using Demo02_Relations.Data;
using Demo02_Relations.Models;
using Microsoft.EntityFrameworkCore;

using var db = new ApplicationDbContext();

//var blogList = db.Blogs.OrderBy(b => b.Name).Include(b => b.Posts).ToList();

//foreach (Blog blog in blogList)
//{
//    Console.WriteLine("--- Blog : ");
//    Console.WriteLine(blog.Name);
//    Console.WriteLine(blog.SiteUri);
//    Console.WriteLine();

//    foreach (Post Post in blog.Posts!.OrderBy(p => p.PublishedOn))
//    {
//        Console.WriteLine($"    -Post {Post.Id}");
//        Console.WriteLine($"    {Post.Title}");
//        Console.WriteLine($"    BlogId = {Post.BlogId}");
//        Console.WriteLine($"    {Post.Content}");
//        Console.WriteLine();
//    }
//}


/****************************************************************************************************/
// ONE TO ONE
// Pour ajouter un header

//db.BlogHeaders.Add(new BlogHeader()
//{
//    Content = "Welcome !",
//    BlogId = 1
//});
//db.SaveChanges();


//var blogDeJenn = db.Blogs.Include(b => b.Header).FirstOrDefault(b => b.Name.Contains("Jennifer"));

//Console.WriteLine(blogDeJenn.Header.Content);


/****************************************************************************************************/
// MANY TO MANY