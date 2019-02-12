using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoDBContext:DbContext
    {

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public PhotoDBContext() : base("name=PhotoSharingDB")
        {

        }
    }
}