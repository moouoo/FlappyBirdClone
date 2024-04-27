using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // public을 이용하여 pipe를 유니티 안에서 관리할 수 있다.
    // 이때 우리가 만들어둔 Pipe(prefab)을 드래그하여 넣어주면 pipe변수안으로 prefab이 들어간다.
    public GameObject pipe;
    
    float timer = 0;
    public float timeDiff;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // deltaTime을 이용해서 컴퓨터의 성능과 관계없이 1초에 같은 fps로 만들어준다.

        if (timer > timeDiff)   //  public을 이용한 외부에서 오브젝트 나오는 주기 설정(timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(6, Random.Range(-2.5f, 5.0f), 0);
            timer = 0;
            Destroy(newPipe, 8.0f);
        }
        // 매 프레임마다 pipe를 찍어내기
        // Instantiate(pipe);
    }
}
