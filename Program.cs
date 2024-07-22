using System.Runtime.InteropServices;

namespace 임준형_Chracter_클래스_선언하기
{
    internal class Program
    {
        class Chracter
        {
            public int level = 1;
            public int hp = 100;
            public int speed = 5;
            public int attackPoint = 20;

            public void MoveFront()
            {
                Console.WriteLine("앞으로 이동");
            }
            public void MoveBack()
            {
                Console.WriteLine("뒤로 이동");
            }
            public void MoveLeftTurn()
            {
                Console.WriteLine("왼쪽으로 이동");
            }
            public void MoveRightTurn()
            {
                Console.WriteLine("오른쪽으로 이동");
            }

            public void Attack(int attackPoint)
            {
                Console.WriteLine($"{attackPoint}만큼의 피해를 입혔습니다.");
            }

            public void Hit(int mosterAttackPoint)
            {
                Console.WriteLine($"{mosterAttackPoint}만큼의 피해를 입었습니다.");
            }
        }
        static void Main(string[] args)
        {
            int mobAttckPoint = 100;
            Chracter chracter = new Chracter();


            chracter.MoveFront();
            chracter.MoveBack();
            chracter.MoveLeftTurn();
            chracter.MoveRightTurn();
            chracter.Attack(chracter.attackPoint);
            chracter.Hit(mobAttckPoint);
        }
    }
}
