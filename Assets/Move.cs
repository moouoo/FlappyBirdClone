using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime은 유저들의 각각의 장치의 성능이 달라 fps차이가 나는것을 각자의 fps(성능?) 만큼 곱해서 게임을 누구나 똑같은 조건으로 할수 있게 보정하는것이다.
        // transform속성은 기본적으로 포함하고 있는 속성이라 Getcomponent를 사용하지 않아도 바로 가져올 수 있다.
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1,0,0) transform속성은 z축도 가지고 있어 Vector3사용
        //Debug.Log(transform.position);
    }
}
