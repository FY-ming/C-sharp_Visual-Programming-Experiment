using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    // 子弹类：表示具有伤害值的子弹对象
    class Bullet
    {
        // 子弹造成的伤害值
        public int Damage { get; set; }


        // 构造函数：初始化子弹伤害值
        public Bullet(int damage)
        {
            Damage = damage;
        }

        // 应用伤害：对目标人物造成伤害，并显示伤害信息
        public void ApplyDamage(Person target)
        {
            if (target != null)
            {
                // 从直接在函数中扣血变成调用角色受伤函数
                target.TakeDamage(Damage);

                //int previousHealth = target.Health;
                //target.Health -= Damage;
                //// 确保血量不低于0
                //if (target.Health < 0)
                //    target.Health = 0;

                //Console.WriteLine($"{target.Name} 受到 {Damage} 点伤害！" +
                //                 $" 血量从 {previousHealth} 减少到 {target.Health}");
            }
        }
    }

    // 弹夹类：管理子弹的存储和发射
    class Clip
    {
        // 当前子弹数量（私有setter确保外部无法直接修改）
        public int CurrentBullets { get; private set; }

        // 子弹类型（所有子弹属性相同）
        public Bullet BulletType { get; set; }

        // 弹夹容量
        public int Capacity { get; set; }

        // 构造函数：初始化弹夹容量和子弹类型
        public Clip(int capacity, Bullet bulletType)
        {
            Capacity = capacity; // 弹夹容量
            BulletType = bulletType; // 子弹类型
            CurrentBullets = 0; // 初始默认无子弹
        }

        // 装填子弹：每次装填1发，返回是否成功装填
        public bool SaveBullet()
        {
            if (CurrentBullets < Capacity)
            {
                CurrentBullets++;
                Console.WriteLine($"已装填1发子弹，当前弹夹子弹数: {CurrentBullets}/{Capacity}");
                return true;
            }
            Console.WriteLine("弹夹已满，无法装填更多子弹！");
            return false;
        }

        // 发射子弹：每次发射1发，返回子弹对象（若有）
        public Bullet ShootBullet()
        {
            if (CurrentBullets > 0)
            {
                CurrentBullets--;
                Console.WriteLine($"射出1发子弹，当前弹夹剩余子弹: {CurrentBullets}/{Capacity}");
                return BulletType;
            }
            Console.WriteLine("弹夹为空，无法射击！");
            return null;
        }
    }
    // 枪类：表示可装备弹夹并发射子弹的武器
    class Gun
    {
        // 当前装备的弹夹（私有setter确保只能通过InstallClip安装）
        public Clip Clip { get; private set; }

        // 安装弹夹：只能安装1个弹夹
        public void InstallClip(Clip clip)
        {
            if (Clip == null)
            {
                Clip = clip;
                Console.WriteLine("弹夹已安装！");
            }
            else
            {
                Console.WriteLine("枪中已有弹夹，无法安装！");
            }
        }

        // 射击：对目标人物发射子弹
        public void Shoot(Person target)
        {
            if (Clip == null)
            {
                Console.WriteLine("请先安装弹夹！");
                return;
            }

            Bullet bullet = Clip.ShootBullet();
            if (bullet != null && target != null)
            {
                Console.WriteLine("射击！");
                bullet.ApplyDamage(target);
            }
        }
    }

    // 人物类：表示游戏中的角色，可装备武器并战斗
    class Person
    {
        public string Name { get; set; } // 人物名称
        public int Health { get; set; } // 人物血量
        public Gun Gun { get; private set; } // 人物持有的枪（私有setter确保只能通过TakeGun持有）
        public bool IsAlive => Health > 0; // 判断人物是否存活

        // 构造函数：初始化人物信息并显示登场信息
        public Person(string name, int health)
        {
            Name = name;
            Health = health;
            Console.WriteLine($"{Name} 出现了，初始血量: {Health}");
        }

        // 装填子弹：向指定弹夹装填指定数量的子弹
        public void LoadBullet(Clip clip, int count)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡，无法装填子弹！");
                return;
            }

            // 计算实际可装填的子弹数（避免超过弹夹容量）
            int bulletsToLoad = Math.Min(count, clip.Capacity - clip.CurrentBullets);

            if (bulletsToLoad > 0)
            {
                Console.WriteLine($"{Name} 正在往弹夹装填 {bulletsToLoad} 发子弹...");
                for (int i = 0; i < bulletsToLoad; i++)
                {
                    clip.SaveBullet();
                }
            }
            else
            {
                Console.WriteLine($"{Name} 尝试装填子弹，但弹夹已满！");
            }
        }

        // 安装弹夹：将弹夹安装到指定枪上
        public void LoadClip(Gun gun, Clip clip)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡，无法安装弹夹！");
                return;
            }

            Console.WriteLine($"{Name} 正在安装弹夹...");
            gun.InstallClip(clip);
        }

        // 拿起枪：装备指定的枪
        public void TakeGun(Gun gun)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡，无法拿起枪！");
                return;
            }

            Gun = gun;
            Console.WriteLine($"{Name} 拿起了枪！");
        }

        // 开火：使用当前持有的枪射击目标
        public void Fire(Person target)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡，无法射击！");
                return;
            }

            if (target != null && !target.IsAlive)
            {
                Console.WriteLine($"目标 {target.Name} 已死亡，无需射击！");
                return;
            }

            if (Gun != null)
            {
                Console.WriteLine($"{Name} 准备射击 {target.Name}！");
                Gun.Shoot(target);
            }
            else
            {
                Console.WriteLine($"{Name} 没有拿枪，无法射击！");
            }
        }

        // 受伤害方法，替代直接修改Health
        public void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡，无法继续受到伤害！");
                return;
            }

            int previousHealth = Health;
            Health -= damage;

            if (Health < 0)
                Health = 0;

            Console.WriteLine($"{Name} 受到 {damage} 点伤害！" +
                             $" 血量从 {previousHealth} 减少到 {Health}");

            if (!IsAlive)
            {
                Console.WriteLine($"{Name} 已死亡！");
            }
        }
    }

    // 程序入口类
    class Program
    {
        static void Main()
        {
            // 创建战士和敌人实例
            Person warrior = new Person("战士", 100);
            Person enemy = new Person("敌人", 100);

            // 创建游戏道具
            Bullet standardBullet = new Bullet(20);  // 标准子弹（伤害20）
            Clip rifleClip = new Clip(30, standardBullet);  // 步枪弹夹（容量30发）
            Gun assaultRifle = new Gun();  // 突击步枪

            // 模拟战斗流程
            warrior.TakeGun(assaultRifle);  // 拿起枪
            warrior.LoadBullet(rifleClip, 10);  // 装填10发子弹
            warrior.LoadClip(assaultRifle, rifleClip);  // 安装弹夹
            warrior.Fire(enemy);  // 射击敌人

            // 模拟战斗流程
            warrior.LoadBullet(rifleClip, 10);  // 装填10发子弹
            warrior.Fire(enemy);  // 射击敌人
            warrior.LoadBullet(rifleClip, 15);  // 装填15发子弹
            warrior.Fire(enemy);  // 射击敌人
            warrior.Fire(enemy);  // 射击敌人
            warrior.Fire(enemy);  // 射击敌人
            warrior.Fire(enemy);  // 射击敌人

            // 尝试对已死亡的敌人射击
            warrior.Fire(enemy);

            // 尝试让已死亡的敌人装填子弹
            enemy.LoadBullet(rifleClip, 5);

            Console.WriteLine("\n战斗结束！");
        }
    }
}
