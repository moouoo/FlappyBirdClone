using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // 클래스 안에 있는 변수를 다른 곳에서 이용하고 그 숫자를 유지하기 위해 static을 이용한다.
    public static int score = 0;
    public static int bestScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();        
    }
}
