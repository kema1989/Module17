using System;

namespace M17U2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Monster
    {
        private IMovement movement;
        private IWeapon weapon;

    }

    interface IMonsterFactory
    {
        IWeapon CreateWeapon();
        IMovement CreateMovement();
    }

    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }

    class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }

    interface IWeapon
    {
        void Attack();
    }
    class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("ОГОНЬ...🎇");
        }
    }

    class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Топорик...");
        }
    }

    interface IMovement
    {
        void StartMoving();
    }

    class FlyMovement : IMovement
    {
        public void StartMoving()
        {
            Console.WriteLine("Летим...");
        }
    }

    class RunMovement : IMovement
    {
        public void StartMoving()
        {
            Console.WriteLine("БЕЖИМ");
        }
    }
}
