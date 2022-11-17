using eTickets.Data.Enums;
using eTickets.Data;
using eTickets.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {

        //Seeding 
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema City Westend",
                            Logo = "https://www.globalplaza.hu/img/up/small_3385_westend-logo.jpg",
                            Description = "Very big cinema in the downtown."
                        },
                        new Cinema()
                        {
                            Name = "Cinema City Aréna",
                            Logo = "https://markamonitor.hu/wp-content/uploads/2018/07/lead_original-35-5.jpg",
                            Description = "The biggest cinema in the city."
                        },
                        new Cinema()
                        {
                            Name = "Sugár Mozi",
                            Logo = "https://www.globalplaza.hu/img/up/small_3442_sugar-logo.jpg",
                            Description = "The developers favorite cinema."
                        },
                        new Cinema()
                        {
                            Name = "Pólus Center Mozi",
                            Logo = "https://www.globalplaza.hu/img/up/small_3436_polus-logo.jpg",
                            Description = "Cinema in the 15th disctrict."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Robert Downes Jr.",
                            Bio = "Robert Downey Jr. has evolved into one of the most respected actors in Hollywood. With an amazing list of credits to his name, he has managed to stay new and fresh even after over four decades in the business.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg/220px-Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Edward Norton",
                            Bio = "Alongside his work in cinema, Norton is an environmental and social activist, and is a member of the board of trustees of Enterprise Community Partners, a non-profit organization for developing affordable housing founded by his grandfather James Rouse.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTYwNjQ5MTI1NF5BMl5BanBnXkFtZTcwMzU5MTI2Mw@@._V1_UY317_CR16,0,214,317_AL_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Chris Hemsworth",
                            Bio = "Christopher Hemsworth AM (born 11 August 1983) is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away (2004–2007) before beginning a film career in Hollywood. In the Marvel Cinematic Universe (MCU), Hemsworth started playing Thor with the 2011 film of the same name and most recently reprised the role in Thor: Love and Thunder (2022), which established him among the world's highest-paid actors.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg/220px-Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Avi Arad",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/5/5d/Avi_Arad_by_Gage_Skidmore.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Kevin Feige",
                            Bio = "Kevin Feige is an American film and television producer who has been the president of Marvel Studios and the primary producer of the Marvel Cinematic Universe franchise since 2007. The films he has produced have a combined worldwide box office gross of over $26.8 billion, making him the highest grossing producer of all time, with Avengers: Endgame becoming the highest-grossing film at the time of its release.Feige is a member of the Producers Guild of America.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/45/Kevin_Feige_2021_Cropped.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Iron Man",
                            Description = "Iron Man is a 2008 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the first film in the Marvel Cinematic Universe (MCU). Directed by Jon Favreau from a screenplay by the writing teams of Mark Fergus and Hawk Ostby, and Art Marcum and Matt Holloway, the film stars Robert Downey Jr. as Tony Stark / Iron Man alongside Terrence Howard, Jeff Bridges, Shaun Toub, and Gwyneth Paltrow. In the film, following his escape from captivity by a terrorist group, world famous industrialist and master engineer Tony Stark builds a mechanized suit of armor and becomes the superhero Iron Man.",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/02/Iron_Man_%282008_film%29_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Scifi
                        },
                        new Movie()
                        {
                            Name = "The Incredible Hulk",
                            Description = "The Incredible Hulk is a 2008 American superhero film based on the Marvel Comics character the Hulk. Produced by Marvel Studios and distributed by Universal Pictures, it is the second film in the Marvel Cinematic Universe (MCU). It was directed by Louis Leterrier from a screenplay by Zak Penn, and stars Edward Norton as Bruce Banner alongside Liv Tyler, Tim Roth, Tim Blake Nelson, Ty Burrell, and William Hurt. In the film, Bruce Banner becomes the Hulk as an unwitting pawn in a military scheme to reinvigorate the 'Super Soldier' program through gamma radiation. Banner goes on the run from the military while attempting to cure himself of the Hulk.",
                            Price = 29.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/f/f0/The_Incredible_Hulk_%28film%29_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Scifi
                        },
                        new Movie()
                        {
                            Name = "Iron Man 2",
                            Description = "Iron Man 2 is a 2010 American superhero film based on the Marvel Comics character Iron Man. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the sequel to Iron Man (2008) and the third film in the Marvel Cinematic Universe (MCU). Directed by Jon Favreau and written by Justin Theroux, the film stars Robert Downey Jr. as Tony Stark / Iron Man alongside Gwyneth Paltrow, Don Cheadle, Scarlett Johansson, Sam Rockwell, Mickey Rourke, and Samuel L. Jackson. Six months after Iron Man, Tony Stark resists calls from the United States government to hand over the Iron Man technology, which is causing his declining health. Meanwhile, Russian scientist Ivan Vanko (Rourke) uses his own version of the technology to pursue a vendetta against the Stark family.",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/e/ed/Iron_Man_2_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Scifi
                        },
                        new Movie()
                        {
                            Name = "Iron Man 3",
                            Description = "Iron Man 3 (titled onscreen as Iron Man Three) is a 2013 American superhero film based on the Marvel Comics character Iron Man, produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures. It is the sequel to Iron Man (2008) and Iron Man 2 (2010), and the seventh film in the Marvel Cinematic Universe (MCU). The film was directed by Shane Black from a screenplay he co-wrote with Drew Pearce, and stars Robert Downey Jr. as Tony Stark / Iron Man alongside Gwyneth Paltrow, Don Cheadle, Guy Pearce, Rebecca Hall, Stéphanie Szostak, James Badge Dale, Jon Favreau, and Ben Kingsley. In Iron Man 3, Tony Stark wrestles with the ramifications of the events of The Avengers during a national terrorism campaign on the United States led by the mysterious Mandarin.",
                            Price = 39.50,
                            ImageURL = "https://en.wikipedia.org/wiki/Iron_Man_3#/media/File:Iron_Man_3_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Scifi
                        },
                        new Movie()
                        {
                            Name = "Thor",
                            Description = "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/9/95/Thor_%28film%29_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 4,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Thor: The Dark World",
                            Description = "Thor: The Dark World is a 2013 American superhero film based on the Marvel Comics character Thor, produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures. It is the sequel to Thor (2011) and the eighth film in the Marvel Cinematic Universe (MCU). The film was directed by Alan Taylor from a screenplay by Christopher Yost and the writing team of Christopher Markus and Stephen McFeely. It stars Chris Hemsworth as Thor alongside Natalie Portman, Tom Hiddleston, Anthony Hopkins, Stellan Skarsgård, Idris Elba, Christopher Eccleston, Adewale Akinnuoye-Agbaje, Kat Dennings, Ray Stevenson, Zachary Levi, Tadanobu Asano, Jaimie Alexander, and Rene Russo. In the film, Thor and Loki (Hiddleston) team up to save the Nine Realms from the Dark Elves.",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/7f/Thor_The_Dark_World_poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Scifi
                        },
                        new Movie()
                        {
                            Name = "Thor: Ragnarok",
                            Description = "Thor: Ragnarok is a 2017 American superhero film based on the Marvel Comics character Thor, produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures. It is the sequel to Thor (2011) and Thor: The Dark World (2013), and is the 17th film in the Marvel Cinematic Universe (MCU). The film was directed by Taika Waititi from a screenplay by Eric Pearson and the writing team of Craig Kyle and Christopher Yost, and stars Chris Hemsworth as Thor alongside Tom Hiddleston, Cate Blanchett, Idris Elba, Jeff Goldblum, Tessa Thompson, Karl Urban, Mark Ruffalo, and Anthony Hopkins. In Thor: Ragnarok, Thor must escape the alien planet Sakaar in time to save Asgard from Hela (Blanchett) and the impending Ragnarök.",
                            Price = 45.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/7d/Thor_Ragnarok_poster.jpg?20191013163714",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Scifi
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 7
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}