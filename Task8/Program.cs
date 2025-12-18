Post[] posts = new Post[5];
posts[0].Title = "Dubai";
posts[0].Description = "We are in Dubai";
posts[0].Like();
posts[0].Like();
posts[0].Like();
posts[1].Title = "AMerica";
posts[1].Description = "We are in America";
posts[1].Like();
posts[1].Like();
posts[1].Like();
posts[2].Title = "England";
posts[2].Description = "We are in England";
posts[2].Like();
posts[2].Like();
posts[2].Like();
posts[3].Title = "Austria";
posts[3].Description = "We are in Austria";
posts[3].Like();
posts[3].Like();
posts[3].Like();
posts[4].Title = "England";
posts[4].Description = "We are in England";
posts[4].Like();
posts[4].Like();
posts[4].Like();
foreach(var p in posts)
{
    System.Console.WriteLine($"{p.Title} {p.Description}");
}
