using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    // Rigidbody2D는 유니티에서 Bird에 설정한 물리속성
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 0을 쓰면 마우스 왼쪽버튼을 눌렀을 떄
        {
            GetComponent<AudioSource>().Play();
            // velocity는 속도를 나타내는 속성
            // rb.velocity = Vector2.up * 3; // Vector2는 2차원좌표로 (x,y)이다. up은(0,1), 곱하기 3이니(0.3)
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
