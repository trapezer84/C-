using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 성적처리
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int kor;
            int eng;
            int mat;
            int total;
            float avg;

            Console.Write("이름: ");
            name = Console.ReadLine();

            Console.Write("국어: ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("영어: ");
            eng = int.Parse(Console.ReadLine());

            Console.Write("수학: ");
            mat = int.Parse(Console.ReadLine());

            total = kor + eng + mat;

            // 실수는 기본이 double로 받아들여서 float하고 연산시 
            // 경고메세지가 나옵니다. 
            // 3.0f 는 flaot 타입 
            avg = total / 3.0f;

            Console.WriteLine("{0} 님의 총점은 {1} 이고 평균은 {2} 입니다.",
                name, total, avg);



        

        }
    }
}
