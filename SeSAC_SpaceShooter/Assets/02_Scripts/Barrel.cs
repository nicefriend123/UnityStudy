using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    private int hitCount = 0;
    public GameObject expEffect;

    [SerializeField] private Texture[] textures;

    private new MeshRenderer renderer;

    void Start()
    {
        //차일드에 이쓴ㄴ MeshRenderer 컴포넌트를 추출
        renderer = GetComponentInChildren<MeshRenderer>();
        //텍스처를 선택하기 위한 난수 발생
        int index = Random.Range(0, textures.Length); // 0,1,2
        //MeshRederer안에 있는 머티리얼에 접근
        renderer.material.mainTexture = textures[index];
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            //++hitCount; // hitCount += 1;
            if (++hitCount >= 3)
            {
                //폭발효과
                ExpBarrel();
            }
        }
    }

    /*
        Random.Range(min,max)
    정수와 실수에 따라 범위가 다르다
        # 정수 
        Random.Range(0, 10) = > 0,1,2,...,9 10포함하지않음

        # 실수
        Random.Range(0.0f, 10.0f) = > 0.0f ~ 10.0f 10포함
    */

    private void ExpBarrel()
    {
        var rb = this.gameObject.AddComponent<Rigidbody>(); //var 키워드는 리턴타입이 확실할 떄 쓰는 것이 좋다

        Vector3 pos = Random.insideUnitSphere; // 단위 구체의 랜덤 값 리턴

        rb.AddExplosionForce(1500.0f, transform.position + pos, 10.0f, 1800.0f); //폭발력 횡 폭발력, 폭발원점 , 폭발간격, 

        Destroy(this.gameObject, 3.0f);

        // Quaternion.identity = 원래 각도 그대로 표현하겠다는 뜻
        var obj = Instantiate(expEffect, transform.position, Quaternion.identity);
        Destroy(obj, 5.0f);


    }
}

internal class start
{
}