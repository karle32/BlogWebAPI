using BlogWebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Data
{
    public class BlogContextSeedData
    {
        private BlogContext _context;

        public BlogContextSeedData(BlogContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {            

            if (!_context.Authors.Any())
            {   
                var authors = new List<Author>()
                {
                    new Author()
                    {
                        Name = "James Reddy",
                        ImageName = "images/profile-1.jpg",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p>",
                        Summary = "This is a test description",
                        BlogPosts = new List<BlogPost>()
                        {
                            new BlogPost()
                            {
                                Title = "A great story never told",
                                Description = "It was a cold December morning, as I sat out on my porch I decided today was the day.",
                                Readtime = 23, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-4", ImageUrl = "images/cover-4.jpg", Name = "Adventure"},
                                    new Category {ImageName = "cover-2", ImageUrl = "images/cover-2.jpg", Name = "Easy Living"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Storytime"},
                                    new Tag {Name = "Easy Living"}
                                }
                            }
                        }
                    },
                    new Author()
                    {
                        Name = "Mad Hacker",
                        ImageName = "images/profile-2.jpg",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p>",
                        Summary = "This is a test description",
                        BlogPosts = new List<BlogPost>()
                        {
                            new BlogPost()
                            {
                                Title = "Builing, Hacking, Creating",
                                Description = "Is it better to start from scratch or build on someone elses work. My thoughts.",
                                Readtime = 9, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-6", ImageUrl = "images/cover-6.jpg", Name = "Storytime"},
                                    new Category {ImageName = "cover-9", ImageUrl = "images/cover-9.jpg", Name = "Open Roads"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Easy Living"}
                                }
                            }
                        }
                    },
                    new Author()
                    {
                        Name = "Sarah Smith",
                        ImageName = "images/profile-4.jpg",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p>",
                        Summary = "This is a test description",
                        BlogPosts = new List<BlogPost>()
                        {
                            new BlogPost()
                            {
                                Title = "Ten reasons why you should travel, or why the city is killing your inner creative",
                                Description = "About time for your next adventure.",
                                Readtime = 5, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-1", ImageUrl = "images/cover-1.jpg", Name = "Gaming"},
                                    new Category {ImageName = "cover-3", ImageUrl = "images/cover-3.jpg", Name = "City Life"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Adventure"}
                                }
                            }
                        }
                    },
                    new Author()
                    {
                        Name = "Jane Thompson",
                        ImageName = "images/profile-5.png",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p>",
                        Summary = "This is a test description",
                        BlogPosts = new List<BlogPost>()
                        {
                            new BlogPost()
                            {
                                Title = "Feature List",
                                Description = "Wondering what is actually included?",
                                Readtime = 2, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-5", ImageUrl = "images/cover-5.jpg", Name = "Rave Culture"},
                                    new Category {ImageName = "cover-7", ImageUrl = "images/cover-7.jpg", Name = "Photography"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Writer"}
                                }
                            }
                        }
                    },
                    new Author()
                    {
                        Name = "Tim Leen",
                        ImageName = "images/profile-3.jpg",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis necessitatibus repellat et similique, assumenda dolor possimus sunt repellendus ratione quas nihil expedita maiores, ex id odio molestiae ipsam officiis magni!</p>",
                        Summary = "This is a test description",
                        BlogPosts = new List<BlogPost>()
                        {
                            new BlogPost()
                            {
                                Title = "Bootstrap Components",
                                Description = "How do some of the default bootstrap components looks",
                                Readtime = 15, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-8", ImageUrl = "images/cover-8.jpg", Name = "Animal Kingdom"},
                                    new Category {ImageName = "cover-10", ImageUrl = "images/cover-10.jpg", Name = "Beach"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Writer"}
                                }
                            },
                            new BlogPost()
                            {
                                Title = "Its not always that simple",
                                Description = "How many times should you ask the same questions.",
                                Readtime = 12, Created = DateTime.Now, Updated = DateTime.Now,
                                Status = "1",
                                HeroImage ="images/default-single-hero.jpg",
                                Content = "This is test content",
                                Categories = new List<Category>()
                                {
                                    new Category {ImageName = "cover-11", ImageUrl = "images/cover-11.jpg", Name = "Climbing"},
                                    new Category {ImageName = "cover-12", ImageUrl = "images/cover-12.jpg", Name = "Mystery"}
                                },
                                Tags = new List<Tag>()
                                {
                                    new Tag {Name = "Open Road"}
                                }
                            }
                        }
                    }
                };
                 
                _context.Authors.AddRange(authors);

                await _context.SaveChangesAsync();   
            }
        }
    }
}
