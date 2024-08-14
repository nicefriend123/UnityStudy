﻿﻿using MyWork;
namespace CSharpProject02;

/* 
# 클래스
    - 변수
    - 메소드(함수)
    - 그룹

# 클래스의 구성 요소
    - 프로퍼티(속성) : 외부에서 접근가능한 변수
    - 필드(멤버변수) : 내부에서 사용하는 변수
    - 메소드(Method) : 함수(로직의 집합)
    - 이벤트(Event) 


# 접근제한자
    - public  : 외부에서 접근가능
    - private : 외부에서 접근불가


# Camel Case (단봉 낙타형)
    - 변수
    - userName

# Pascal Case 
    - 클래스
    - 메소드
    - 프로퍼티
    - Enemy, Main
    - PlayerHp

*/
public class Enemy
{
    // 멤버변수 (기본적으로 외부 접근 금지)
    //private string name;
    private int hp = 100;
    //private float speed = 10.0f;

    // 프로퍼티(Property) - 외부에 노출시킬 속성
    public string Name { get; set; }
    // Auto Property
    public float Speed { get; set; }

    public int Hp
    {
        get { return this.hp; }
        set
        {
            this.hp = value;
            if (hp <= 0)
            {
                EnemyDie(Name);
            }
        }
    }

    public virtual void EnemyDie(string param)
    {
        // 몬스터가 사망하는 로직 처리
        Console.WriteLine($"부모클래스 : {param} is dead!!!");

    }
}
// Enemy 클래스를 상속한 오크
public class Orc : Enemy
{
    // 생성자 constructor
    // 객체 호출시 생성자가 생성되고 초기 값을 설정해줄 때 생성자를 사용한다
    public Orc()
    {
        this.Name = "오크";
        this.Hp = 200;
        this.Speed = 50;
    }

    public override void EnemyDie(string param)
    {
        base.EnemyDie(param); //base는 부모클래스 의미, 부모클래스에 있는 enemydie를 먼저 실행 시킬 것이다
        
        //Orc 로직을 구현
        System.Console.WriteLine("자식 클래스 : 비명을 지르면서 죽고 골드를 떨어뜨린다.");
    }
}

public class Goblin : Enemy
{
    // 파라미터가 있는 생성자
    public Goblin(string _name, int _hp, int _speed)
    {
        this.Name = _name;
        this.Hp = _hp;
        this.Speed = _speed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemy orc = new Orc(); // 생성자에서 이름 체력 등을 불러옴
        Goblin goblin = new Goblin("고블린", 50, 200);

        console.WriteLine($"Enemy's name is {orc.Name}");
        System.Console.WriteLine(goblin.Name);

        goblin.Hp = 0;
        orc.Hp = 0;

        // // 1. 일반적인 클래스 생성및 할당
        // Enemy orc = new Enemy();
        // orc.Name = "Orc";
        // orc.Hp = 0;

        // // 2.
        // Enemy goblin = new Enemy()
        // {
        //     Name = "Goblin",
        //     Hp = 200,
        //     Speed = 100
        // };
        // Console.WriteLine($"Enemy's name is {orc.Name}");
    }
}