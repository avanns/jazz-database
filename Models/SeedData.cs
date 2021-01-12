using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcJazz.Data;
using System;
using System.Linq;

namespace MvcJazz.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcJazzContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcJazzContext>>()))
            {
                // Look for any albums.
                if (context.Album.Any())
                {
                    return;   // DB has been seeded
                }

                context.Album.AddRange(
                    new Album
                    {
                        Artist = "John Coltrane",
                        Title = "Giant Steps",
                        RecordingDate = DateTime.Parse("1959-5-4"),
                        Personnel = "John Coltrane - ts, Tommy Flanagan - p, Paul Chambers - db, Art Taylor - dr, Wynton Kelly - p (6), Jimmy Cobb - dr (6)",
                        AlbumImage = "https://coverartarchive.org/release-group/2cdca11d-3e45-3152-93e5-4d2a4ddb1bc6/front-500.jpg"
                    },
                    new Album
                    {
                        Artist = "Sonny Rollins",
                        Title = "Saxophone Colossus",
                        RecordingDate = DateTime.Parse("1956-6-22"),
                        Personnel = "Sonny Rollins - ts, Tommy Flanagan - p, Doug Watkins - db, Max Roach - dr",
                        AlbumImage = "https://coverartarchive.org/release-group/cf29d6a2-a18a-3bb6-a861-495148baee1f/front-500.jpg"
                    },

                    new Album
                    {
                        Artist = "Miles Davis",
                        Title = "Kind of Blue",
                        RecordingDate = DateTime.Parse("1959-3-2"),
                        Personnel = "Miles Davis - tp, John Coltrane - ts, Cannonball Adderly - as, Bill Evans - p, Wynton Kelly - p (2), Paul Chambers - db, Jimmy Cobb - dr",
                        AlbumImage = "https://coverartarchive.org/release-group/8e8a594f-2175-38c7-a871-abb68ec363e7/front-500.jpg"
                    },

                    new Album
                    {
                        Artist = "Wayne Shorter",
                        Title = "Speak No Evil",
                        RecordingDate = DateTime.Parse("1964-12-24"),
                        Personnel = "Wayne Shorter - ts, Freddie Hubbard - tp, Herbie Hancock - p, Ron Carter - db, Elvin Jones - dr",
                        AlbumImage = "https://coverartarchive.org/release-group/eae0c18f-f2fd-3b97-8631-3f682a2f3957/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Charles Mingus",
                        Title = "Mingus Ah Um",
                        RecordingDate = DateTime.Parse("1959-05-05"),
                        Personnel = "John Handy as(1, 6, 7, 9, 10, 11, 12), cl(8), ts (2), Booker Ervin – ts, Shafi Hadi – ts (2, 3, 4, 7, 8, 10), as (1, 5, 6, 9, 12), Willie Dennis – trb (3, 4, 5, 12), Jimmy Knepper – trb (1, 7, 8, 9, 10), Horace Parlan – p, Charles Mingus – bass, p (with Parlan on track 10), Dannie Richmond – dr",
                        AlbumImage = "https://coverartarchive.org/release/c01e7a26-0570-402b-be41-bd4a697f329a/10086815799-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Keith Jarrett",
                        Title = "The Köln Concert",
                        RecordingDate = DateTime.Parse("1975-01-21"),
                        Personnel = "Keith Jarrett - p",
                        AlbumImage = "https://coverartarchive.org/release-group/516d4629-7bf3-3ac3-907a-ed9a022db840/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "John Coltrane",
                        Title = "Coltrane Jazz",
                        RecordingDate = DateTime.Parse("1959-12-02"),
                        Personnel = "John Coltrane - ts, Wynton Kelly - p, Paul Chambers -db, Jimmy Cobb - dr, McCoy Tyner - p (2), Steve Davis - db (2), Elvin Jones - dr (2)",
                        AlbumImage = "https://coverartarchive.org/release/710c8bad-ce09-4d33-a584-a396e5b74a1c/3722887694-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Kenny Dorham",
                        Title = "Blue Spring",
                        RecordingDate = DateTime.Parse("1959-01-20"),
                        Personnel = "Kenny Dorham - tr, Cannonball Adderley - as, David Amram - fh, Cecil Payne - bs, Cedar Walton - p, Paul Chambers - db, Jimmy Cobb - dr (1-4), Philly Joe Jones - dr (5-6)",
                        AlbumImage = "https://coverartarchive.org/release-group/d9573968-c095-4800-a356-38ea0339ee3d/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Wynton Kelly",
                        Title = "Kelly Blue",
                        RecordingDate = DateTime.Parse("1959-02-19"),
                        Personnel = "Wynton Kelly – p, Nat Adderley – ct (1 & 5), Bobby Jaspar – fl (1 & 5), Benny Golson – ts (1 & 5), Paul Chambers – db, Jimmy Cobb – dr",
                        AlbumImage = "https://coverartarchive.org/release-group/298f7876-03be-3897-b4ac-86eb95607594/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Cannonball Adderley",
                        Title = "Cannonball Adderley Quintet in Chicago",
                        RecordingDate = DateTime.Parse("1959-02-03"),
                        Personnel = "Cannonball Adderley – as (except 5), John Coltrane – ts (except 2)Wynton Kelly – p, Paul Chambers – db, Jimmy Cobb – dr",
                        AlbumImage = "https://coverartarchive.org/release-group/e5f68ad0-20af-3605-aa4d-089954ea2622/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Miles Davis",
                        Title = "Relaxin' with the Miles Davis Quintet",
                        RecordingDate = DateTime.Parse("1956-05-11"),
                        Personnel = "Miles Davis - tr, John Coltrane - ts, Red Garland - p, Paul Chambers, Philly Joe Jones - dr",
                        AlbumImage = "https://coverartarchive.org/release-group/afb1433e-c8b6-3924-8798-c494a3040346/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Booker Ervin",
                        Title = "That's It!",
                        RecordingDate = DateTime.Parse("1961-01-06"),
                        Personnel = "Booker Ervin - ts, Horace Parlan - p, George Tucker - bass, Al Harewood - drums",
                        AlbumImage = "https://coverartarchive.org/release-group/10dfdb02-50f9-4282-920c-fb059e90abc5/front-500.jpg"
                    },
                    
                    new Album
                    {
                        Artist = "Eric Dolphy",
                        Title = "Out to Lunch!",
                        RecordingDate = DateTime.Parse("1964-02-25"),
                        Personnel = "Eric Dolphy – bc (1 & 2),fl (3), as (4 & 5), Freddie Hubbard – tr, Bobby Hutcherson – vb, Richard Davis – db, Tony Williams – dr",
                        AlbumImage = "https://coverartarchive.org/release-group/bc6c2573-bc7d-346a-8880-0e34b8fb7e50/front-500.jpg"
                    }
                    
                    
                );
                context.SaveChanges();
            }
        }
    }
}