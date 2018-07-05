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

        public IActionResult GetUserComments()
        {

            return View(dataSource.Users);
        }

        public IActionResult GetUserTodos()
        {

            return View(dataSource.Users);
        }

        public IActionResult GetSortedUsers()
        {

            return View(dataSource.Users);
        }

        public IActionResult GetAdditionalUserInfo()
        {

            return View(dataSource.Users);
        }

        public IActionResult GetAdditionalPostInfo()
        {

            return View(dataSource.Users);
        }

    }
}