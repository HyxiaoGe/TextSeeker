using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSeeker.DataAccess;
using TextSeeker.Models;

namespace TextSeeker.BusinessLogic
{
    public class VideoService
    {

        private AppDbContext appDbContext;

        public VideoService()
        {
            appDbContext = new AppDbContext();
        }

        public void addVideo(string title, string author)
        {
            var video = new Video { Title = title, Author = author };
            appDbContext.Video.Add(video);
            appDbContext.SaveChanges();
        }

        public List<Video> getVideoList(string keyword, string author)
        {
            Console.WriteLine(keyword);
            var query = appDbContext.Video.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(video => video.Title.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(author))
            {
                query = query.Where(video => video.Author.Contains(author));
            }

            return query.ToList();
        }

    }
}
