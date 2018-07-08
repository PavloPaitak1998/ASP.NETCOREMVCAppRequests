using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAppASPCoreMVCRequests.Data;
using WebAppASPCoreMVCRequests.Services;

namespace WebAppASPCoreMVCRequests.Controllers
{
    public class DataRequestController : Controller
    {
        DataSource dataSource;

        public DataRequestController(DataSource _dataSource)
        {
            dataSource = _dataSource;
        }

        //GET: /DataRequest/Info
        public IActionResult Info(string actionId, string message)
        {
            return View((actionId,message));
        }

        //GET: /DataRequest/GetAllData
        public IActionResult GetAllData()
        {
            return View(dataSource.Users);
        }

        //GET: /DataRequest/GetCommentsCount
        public IActionResult GetCommentsCount(int id)
        {
            if (!dataSource.Users.Exists(u=>u.Id==id))
            {
                return Redirect($"~/DataRequest/Info?actionId=1&message=User with this id {id} doesn't exist !");
            }

            var commentsCount = LinqRequests.CommentsCount(id,dataSource.Posts);

            return View(commentsCount);
        }

        //GET: /DataRequest/GetUserComments
        public IActionResult GetUserComments(int id)
        {
            if (!dataSource.Users.Exists(u => u.Id == id))
            {
                return Redirect($"~/DataRequest/Info?actionId=2&message=User with this id {id} doesn't exist !");
            }

            var res = LinqRequests.GetUserComments(id, dataSource.Posts);
            return View(res);
        }

        //GET: /DataRequest/GetUserTodos
        public IActionResult GetUserTodos(int id)
        {
            if (!dataSource.Users.Exists(u => u.Id == id))
            {
                return Redirect($"~/DataRequest/Info?actionId=3&message=User with this id {id} doesn't exist !");
            }

            var res = LinqRequests.GetUserTodos(id, dataSource.Todos);
            return View(res);
        }

        //GET: /DataRequest/GetSortedUsers
        public IActionResult GetSortedUsers()
        {
            var res = LinqRequests.GetSortedUsers(dataSource.Users);

            return View(res);
        }

        //GET: /DataRequest/GetAdditionalUserInfo
        public IActionResult GetAdditionalUserInfo(int id)
        {
            if (!dataSource.Users.Exists(u => u.Id == id))
            {
                return Redirect($"~/DataRequest/Info?actionId=5&message=User with this id {id} doesn't exist !");
            }

            var res = LinqRequests.GetAdditionalUserInfo(id, dataSource.Users);

            return View(res);
        }

        //GET: /DataRequest/GetAdditionalPostInfo
        public IActionResult GetAdditionalPostInfo(int id)
        {
            if (!dataSource.Posts.Exists(p => p.Id == id))
            {
                return Redirect($"~/DataRequest/Info?actionId=6&message=Post with this id {id} doesn't exist !");
            }

            var res = LinqRequests.GetAdditionalPostInfo(id, dataSource.Posts);

            return View(res);
        }

        //GET: /DataRequest/UserInfo
        public IActionResult UserInfo(int id)
        {
            var res = dataSource.Users.Find(u => u.Id==id);

            return View(res);
        }

        //GET: /DataRequest/PostInfo
        public IActionResult PostInfo(int id)
        {
            var res = LinqRequests.GetPostUserList(dataSource.Posts, dataSource.Users).FirstOrDefault(t => t.Post.Id == id);

            return View(res);
        }

        //GET: /DataRequest/TodoInfo
        public IActionResult TodoInfo(int id)
        {
            var res = dataSource.Todos.Find(t => t.Id == id);

            return View(res);
        }

        //GET: /DataRequest/Posts
        public IActionResult Posts()
        {
            var res = LinqRequests.GetPostUserList(dataSource.Posts, dataSource.Users);

            return View(res);
        }

        //GET: /DataRequest/Todos
        public IActionResult Todos()
        {
            return View(dataSource.Users);
        }

    }
}