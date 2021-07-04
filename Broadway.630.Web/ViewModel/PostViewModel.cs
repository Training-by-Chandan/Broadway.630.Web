using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class RandomPostGenerator
    {
        public static PostViewModel Generate()
        {
            var post = new PostViewModel()
            {
                ImagePath = "/admintheme/dist/img/photo2.png",
                Caption = "I clicked this, how is this guys?"
            };
            var author = new PostedByViewModel()
            {
                Name = "Niroj",
                profilePicture = "/admintheme/dist/img/user1-128x128.jpg"
            };
            var listComments = new List<CommentsViewModel>();
            var comment1 = new CommentsViewModel()
            {
                CommentorName = "Ashish",
                CommentorProfilePic = "/admintheme/dist/img/user2-128x128.jpg",
                CommentText = "Wow nice picture!"
            };

            var comment2 = new CommentsViewModel()
            {
                CommentorName = "Pallabi",
                CommentorProfilePic = "/admintheme/dist/img/user3-128x128.jpg",
                CommentText = "Oho khatra picture!"
            };

            var comment3 = new CommentsViewModel()
            {
                CommentorName = "Chandan",
                CommentorProfilePic = "/admintheme/dist/img/user4-128x128.jpg",
                CommentText = "Aag laga dala!"
            };

            listComments.Add(comment1);
            listComments.Add(comment2);
            listComments.Add(comment3);

            post.Author = author;
            post.Comments = listComments;

            return post;
        }
    }

    public class PostViewModel
    {
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public PostedByViewModel Author { get; set; }
        public List<CommentsViewModel> Comments { get; set; }
    }

    public class PostedByViewModel
    {
        public string Name { get; set; }
        public string profilePicture { get; set; }
    }

    public class CommentsViewModel
    {
        public string CommentorName { get; set; }
        public string CommentText { get; set; }
        public string CommentorProfilePic { get; set; }
    }
}