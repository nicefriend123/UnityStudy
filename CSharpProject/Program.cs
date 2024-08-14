using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace CSharpProject;

class Program
{
    static void Main(string[] args)
    {
        /*
        while Loop

        while (조건식){
        조건식;
        }

        do while 

        do{
        
        }
        while(조건식)
        */

        int k = 0;
        int sum = 0;
        while (k <= 10)
        {
            sum += k;
            ++k;
            //sum += k++; // 이 코드는 가독성이 조금 떨어지기 때문에 지양하는게 좋다
        }

        System.Console.WriteLine(sum);
    }//Main Class
} //End of Class
