using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托代码练习
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3、定义委托变量(引用类型)
            LectureDelegate lecture=null;
            LectureCourse lectureCourse = null;

            //4、将具体方法与委托变量关联
            lecture = ChangLecture1;
            lecture += ChangLecture2;
            lecture += ChangLecture3;

            //5、通过委托变量使用方法

            lecture();
            Console.WriteLine("*****************************");
            lecture -= ChangLecture1;

            lecture.Invoke();//特有的invoke方法
            Console.WriteLine("*****************************");

            lectureCourse = ChangLecture12;
            Console.WriteLine(lectureCourse(10,"JAVA"));

            Console.Read();


        }

        //2、根据委托编写方法
        static void ChangLecture1()
        {
            Console.WriteLine("我正在学习C#");
        }

        static void ChangLecture2()
        {
            Console.WriteLine("我正在学习JAVA");
        }
        static void ChangLecture3()
        {
            Console.WriteLine("我正在学习SQL");
        }

        static string ChangLecture12(int count,string course)
        {
             return $"常老师主讲的 {course} 课时 {count}";
        }
        static string ChangLecture22(int count, string course)
        {
            return $"王老师主讲的 {course} 课时 {count}";
        }
        static string ChangLecture32(int count, string course)
        {
            return $"赵老师主讲的 {course} 课时 {count}";
        }
    }

    //1、声明委托(方法的原型)
    public delegate void LectureDelegate();
    public delegate string LectureCourse(int num,string content);
}
