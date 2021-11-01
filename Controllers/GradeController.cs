using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WE_Asgn_1.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public ActionResult Result()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Result(FormCollection request)
        {
            int dds = int.Parse(request["ddsTxt"]);
            int wdd = int.Parse(request["wddTxt"]);
            int pf = int.Parse(request["pfTxt"]);
            int oop = int.Parse(request["oopTxt"]);
            int we = int.Parse(request["weTxt"]);
            CalculateResult(ref dds, ref wdd, ref pf, ref oop, ref we);
            return View();
        }
        private void CalculateResult(ref int dds, ref int wdd, ref int pf, ref int oop, ref int we)
        {
            int totalMarks = 500;   //100 marks for each subject
            int obtainedMarks = dds + wdd + pf + oop + we;
            int percentage = (int)Math.Round((double)(obtainedMarks * 100) / totalMarks);
            char grade;
            if (percentage >= 80)
            {
                grade = 'A';
            }
            else if (percentage >= 70)
            {
                grade = 'B';
            }
            else if (percentage >= 60)
            {
                grade = 'C';
            }
            else if (percentage >= 40)
            {
                grade = 'B';
            }
            else
            {
                grade = 'F';
            }
            ViewBag.percent = percentage;
            ViewBag.grade = grade;
        }
    }
}