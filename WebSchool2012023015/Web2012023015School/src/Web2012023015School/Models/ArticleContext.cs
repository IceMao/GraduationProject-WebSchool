﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2012023015School.Models
{
    public class ArticleContext : IdentityDbContext<User>
    {
        public DbSet<Article> Article { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Inform> Inform { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<RecruitStudents> RecruitStudents { get; set; }
        public DbSet<SchoolInfo> SchoolInfo { get; set; }
        public DbSet<GuestBook> GuestBook { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GuestBook>(e =>
            {
                //添加留言板的Time的索引
                    e.Index(x => x.Time);
               
            });

            builder.Entity<Inform>(e =>
            {
                //添加通知公告索引
                e.Index(x => x.Id);
                e.Index(x => x.Datatime);

            });

            builder.Entity<Article>(e =>
            {
                //添加文章索引
                e.Index(x => x.Id);
                e.Index(x => x.Source);
                e.Index(x => x.Datatime);
            });

            builder.Entity<News>(e =>
            {
                //添加新闻索引
                e.Index(x => x.Id);
                e.Index(x => x.Datatime);
                e.Index(x => x.Source);

            });

        }
    }
}
