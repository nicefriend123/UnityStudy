namespace CSharpProject02;

/*
    # 클래스
     - 변수
     - 메소드(함수) = 보통 OOP에서는 메소드라고 하고 객체지향 관점이 아닌 경우 함수라고 한다
     - 그룹
    # 클래스의 구성 요소
     - 프로퍼티(속성) : 외부에서 접근 가능한 변수
     - 필드(멤버변수) : 내부에서 사용하는 변수
     - 메소드(Method) : 함수(로직의 집합)
     - 이벤트(Event)

     # 접근제한자
     - public : 외부에서 접근 가능
     - private : 외부에서 접근 불가
    기본적으로 클래스 앞에 접근제한자를 붙이지 않으면 private가 기본

    # 대소문자 사용 방법
    - Camel Case (단봉 낙타형)
        - 변수
        - userName
    - Pascal Case
        - 클래스
        - 메소드
        - 프로퍼티
        - Enemy, Main , PlayerHp 등..
*/

public class Enemy
{
    // 멤버변수 (기본적으로 외부 접근 금지)
    private string name;
    private int hp = 100;
    private float speed = 10.0f;

    //프로퍼티(Property) - 외부에 노출시킬 속성
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Hp
    {
        get { return this.hp; }
        set
        {
            this.hp = value;
            if (hp <= 0)
            {
                //몬스터가 사망하는 로직 처리
                System.Console.WriteLine($"{name} is dead");
            }

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemy orc = new Enemy();
        orc.Name = "Orc";
        orc.Hp = 0;

        System.Console.WriteLine($"Enemy`s name is {orc.Name}");
    }
}
