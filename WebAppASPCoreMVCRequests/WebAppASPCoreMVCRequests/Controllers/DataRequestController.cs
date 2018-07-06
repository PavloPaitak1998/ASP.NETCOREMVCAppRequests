using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Info()
        {

            return View();
        }

        public IActionResult GetAllData()
        {

            return View(dataSource.Users);
        }

        public IActionResult GetCommentsCount(int id)
        {
            var commentsCount = LinqRequests.CommentsCount(id,dataSource.Posts);

            return View(commentsCount);
        }

        public IActionResult GetUserComments(int id)
        {
            var res = LinqRequests.GetUserComments(id, dataSource.Posts);
            return View(res);
        }

        public IActionResult GetUserTodos(int id)
        {
            var res = LinqRequests.GetUserTodos(id, dataSource.Todos);
            return View(res);
        }

        public IActionResult GetSortedUsers()
        {
            var res = LinqRequests.GetSortedUsers(dataSource.Users);

            return View(res);
        }

        public IActionResult GetAdditionalUserInfo(int id)
        {
            var res = LinqRequests.GetAdditionalUserInfo(id, dataSource.Users);

            return View(res);
        }

        public IActionResult GetAdditionalPostInfo(int id)
        {
            var res = LinqRequests.GetAdditionalPostInfo(id, dataSource.Posts);

            return View(res);
        }

        public IActionResult UserInfo(int id)
        {
            var res = dataSource.Users.Find(u => u.Id==id);

            return View(res);
        }

    }
}