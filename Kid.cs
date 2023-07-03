using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_Inheritance
{    
    class Kid : Mother //روبه روی کلاسی که میخوایم ویژگی های کلاس دیگه ما یعنی کلاس پدر رو به ارث ببره یک دو نقطه میزاریم و اسم کلاس دیگرمون رو مینویسیم
        //در سی شارپ ارس بری چند گانه با اضافه کردن دو نقطه های دیگر امکان پذیر نیست بلکه با اضافه کردن اینترفیس و (,) امکان پذیر است
        //یا اینکه ابتدا کلاس دوم از کلاس اول ارث ببرد و سپس کلاس سوم از کلاس دوم ارث ببرد تا کلاس سوم ویژگی های کلاس اول را هم داشته باشد
    {
        public static int Multiple(int a, int b)
        {
            return a * b;
        }

        public void MEx()
        {
            Mother M = new Mother();
            //M.Abc = 10;
            //Abc = 10;
            Sum(5, 6);
        }
    }
}
