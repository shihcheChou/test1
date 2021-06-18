﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test11.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        //可接受 name 參數,string型態可為空
        //可接受 weight 參數,float型態不可為空,所以在float?要加上問號表示可為空
        public ActionResult Index(string name, float? weight)
        {
            var result = " ";//預算計算為空為空字串
            if(weight.HasValue)//判斷使用者有無輸入體重
            {
                result = (weight * 30) + "cc";//根據體重 * 30,算完之後將數值加上單位cc的字串
            }
            ViewBag.Name = name;//將數值傳給View顯示
            ViewBag.Result = result;


            return View(); 
        }
    }
}