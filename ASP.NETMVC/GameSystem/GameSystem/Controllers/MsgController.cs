using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameSystem.Models;

namespace GameSystem.Controllers
{
    public class MsgController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: Msg 获取信息列表
        public ActionResult Index()
        {
            var msg = db.Msg.Include(m => m.Account);
            return View(msg.ToList());
        }

        // GET: Msg/Details/5 通过信息id查询信息详情
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Msg msg = db.Msg.Find(id);
            //点击+1
            msg.MsgHit++;
            db.Entry(msg).State = EntityState.Modified;
            db.SaveChanges();
            if (msg == null)
            {
                return HttpNotFound();
            }
            return View(msg);
        }

        // GET: Msg/Create 新增信息
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Msg msg, HttpPostedFileBase photo)
        {
            if (ModelState.IsValid)
            {
                //判断用户是否登录，登录后才允许新增信息
                if (Session["Login"] != null)
                {
                    if (photo != null)
                    {
                        msg.MsgPhoto = "/img/" + photo.FileName;
                        photo.SaveAs(Server.MapPath(msg.MsgPhoto));
                    }
                    msg.MsgHit = 0; //默认点击数为0
                    msg.MsgTime = System.DateTime.Now; //信息登记时间为当前时间
                    msg.AccountID = ((Account)Session["Login"]).AccountID;//作者为当前登录用户
                    try
                    {
                        db.Msg.Add(msg);
                        db.SaveChanges();
                        return RedirectToAction("Index");//新增成功后跳转到列表页
                    }
                    catch (Exception)
                    {
                        TempData["msg"] = "新增失败!";
                    }
                }
                else TempData["msg"] = "请先登录!";
            }
            else TempData["msg"] = "表单验证失败!";
            return View(msg);
        }

        // GET: Msg/Edit/5 修改信息
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Msg msg = db.Msg.Find(id);
            if (msg == null) return HttpNotFound();
            return View(msg);
        }
        [HttpPost]
        public ActionResult Edit(Msg msg, HttpPostedFileBase photo)
        {
            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    msg.MsgPhoto = "/img/" + photo.FileName;
                    photo.SaveAs(Server.MapPath(msg.MsgPhoto));
                }
                try
                {
                    db.Entry(msg).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    TempData["msg"] = "修改失败!";
                }
            }
            else TempData["msg"] = "表单验证失败!";
            return View(msg);
        }

        // GET: Msg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Msg msg = db.Msg.Find(id);
            if (msg == null)
            {
                return HttpNotFound();
            }
            return View(msg);
        }

        // POST: Msg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Msg msg = db.Msg.Find(id);
            db.Msg.Remove(msg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
