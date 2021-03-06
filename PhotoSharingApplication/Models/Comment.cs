﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class Comment
    {

        public int CommentID   { get; set; }
        public string UserName { get; set; }
        public string Subject   { get; set; }
        public string Body     { get; set; }

        public int PhotoID { get; set; }
        public virtual Photo photo { get; set; }
    }
}