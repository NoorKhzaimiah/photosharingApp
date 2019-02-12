using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingSample : DropCreateDatabaseAlways<PhotoDBContext>
    {
       

        protected override void Seed(PhotoDBContext context)
        {
            base.Seed(context);


             var newPhotos = new List<Photo>
            {
                new Photo {
                    Title = "Me standing on top of a mountain",
                    Description = "I was very impressed with myself",
                    UserName = "Fred",
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today
                },
                new Photo {
                    Title = "My New Adventure Works Bike",
                    Description = "It's the bees knees!",
                    UserName = "Fred",
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today
                },
                new Photo {
                    Title = "View from the start line",
                    Description = "I took this photo just before we started over my handle bars.",
                    UserName = "Sue",
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today
                }
            };






             newPhotos.ForEach(s => context.Photos.Add(s));






             context.SaveChanges();

            /*
            //Create some comments
            var comments = new List<Comment>
            {
                new Comment {
                    PhotoID = 1,
                    UserName = "Bert",
                    Subject = "A Big Mountain",
                    Body = "That looks like a very high mountain you have climbed"
                },
                new Comment {
                    PhotoID = 1,
                    UserName = "Sue",
                    Subject = "So?",
                    Body = "I climbed a mountain that high before breakfast everyday"
                },
                new Comment {
                    PhotoID = 2,
                    UserName = "Fred",
                    Subject = "Jealous",
                    Body = "Wow, that new bike looks great!"
                }
            };
            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();

    */
        }
    }
}