using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //DbContext是一个管理数据库和应用程序通信的类
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // 将会在数据库中创建一个名为Users的表，而表包括的属性即AppUser类中的属性
        public DbSet<AppUser> Users { get; set; }
    }
}