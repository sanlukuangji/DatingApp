using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        // public int Id {get; set;} 相当于AppUser这个类中定义一个Id属性，类型为int，有预定义的getter和setter方法
        public int Id { get; set; }
        // string? 表示声明UserName这个属性是可以为空的
        public string UserName { get; set; }
    }
}