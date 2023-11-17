namespace _2023._11._15
{
    internal class Program
    {
        public interface IMovable
        {
            void Move(int x, int y); // 이동 메서드 선언
        }
        public class Player : IMovable
        {
            public void Move(int x, int y)
            {
                // 플레이어의 이동 구현
            }
        }

        public class Enemy : IMovable
        {
            public void Move(int x, int y)
            {
                // 적의 이동 구현
            }
        }

        static void Main(string[] args)
        {
            IMovable movableObject1 = new Player();
            IMovable movableObject2 = new Enemy();

            movableObject1.Move(5, 0); // 플레이어 이동
            movableObject2.Move(1, 9); // 적 이동
        }
    }
}