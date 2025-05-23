using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Warrior c = new Warrior("전사");
            Warrior d = new Warrior();

        }
    }

   public  class Character
    {
        public string name;

        public Character(string name)
        {
            this.name = name;
            Console.WriteLine($"부모클래스 생성자 호출. 이름설정 = {name}");
        }

        public Character()
        {
            name = "마법사";
            Console.WriteLine($"부모클래스 생성자 호출. 이름설정 = {name}");
        }
    }

    public class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            // 현 상황에서는 'name', 'base.name'이 동일하게 동작한다.
            Console.WriteLine($"전사 {name} 생성 완료");
        }

        public Warrior()
        {
            // 현 상황에서는 'name', 'base.name'이 동일하게 동작한다.
            Console.WriteLine($"전사 {name} 생성 완료");
        }
    }
}
