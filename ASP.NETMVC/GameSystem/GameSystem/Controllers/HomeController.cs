using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
using GameSystem.Models;

namespace GameSystem.Controllers
{
    public class HomeController : Controller
    {
        private GameDBEntities db = new GameDBEntities();
        public ActionResult Index()
        {
            //贪婪加载作者信息，按信息时间倒序排序
            ViewBag.list = db.Msg.Include("Account")
                .OrderByDescending(o => o.MsgTime).ToList();

            return View();
        }

        public ActionResult News()
        {
            //查询类型为新闻公告的资讯信息并贪婪加载作者信息
            ViewBag.list = db.Msg.Include("Account")
                .Where(m => m.MsgType == "新闻公告")
                .OrderByDescending(o => o.MsgTime).ToList();
            return View();
        }

        public ActionResult Heros()
        {
            //查询类型为英雄档案的资讯信息并贪婪加载作者信息
            ViewBag.list = db.Msg.Include("Account")
                .Where(m => m.MsgType == "英雄档案")
                .OrderByDescending(o => o.MsgTime).ToList();
            return View();
        }

        public ActionResult Videos()
        {
            //查询类型为视频图片的资讯信息并贪婪加载作者信息
            ViewBag.list = db.Msg.Include("Account")
                .Where(m => m.MsgType == "视频图片")
                .OrderByDescending(o => o.MsgTime).ToList();
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}