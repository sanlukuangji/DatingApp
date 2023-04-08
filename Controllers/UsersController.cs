using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // 表明该控制器是一个web api类控制器
    [ApiController]
    // 这个类的路由是api/users，注意这里[controller]是一个占位符，会被替换为类名去掉controller后的名字
    [Route("api/[controller]")]
    public class UsersController
    {
        
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
            
        }

        // 该方法响应http get请求，GetUsers将返回一个AppUser的集合（所有的AppUser），并将其包装在ActionResult中
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            // 隐式声明users的类型，通过后面的初始化可以被编译器推断出来
            var users = await _context.Users.ToListAsync();
            return users;
        }

        // 该方法获取指定Id的user的信息
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}