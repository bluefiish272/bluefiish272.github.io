using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Filter.Models;

namespace Filter.Controllers
{
     [AddHeader("controller", "Demo")]
    public class DemoController : Controller
    {
        [AddHeader("user", "17842")]
        public IActionResult WithAttribute()
        {
            return View();
        }

        public IActionResult WithoutAttribute()
        {
            return View();
        }

        public IActionResult Exception()
        {
            throw new Exception("唷!~在Controller發生問題啦~");
        }

        public IActionResult ExceptionA()
        {
            throw new Exception("是誰呢~發生錯誤啦!");
        }
    }
}
