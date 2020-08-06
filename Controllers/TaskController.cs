using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace tests.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public ActionResult Task1(int[] input)
        {
            var res = TestsUtils.SolveArrays(input);

            return Ok(res);
        }

        [HttpGet]
        public ActionResult Task2(LinkedList<int> first, LinkedList<int> secont)
        {
            var res = TestsUtils.Summ(first, secont);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult Task3(string input)
        {
            
            
            var res = TestsUtils.IsPalindrome(input);

            return Ok(res);
        }
    }
}