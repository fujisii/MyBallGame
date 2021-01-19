using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);

        // ボールを逃したらゲームオーバー
        if (transform.position.z < -13.0f)
        {
            // Debug.Log("Game Over");
            // // ゲーム内の時間を止める
            // Time.timeScale = 0;

            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            // パドルにボールが当たったらボールを削除する
            Destroy(gameObject);
            // パドルにボールが当たったらパドルの長さを短くしていく
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            // パドルの長さが指定値より短くなったら固定する
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1, 1.0f, 1.0f);
            }
        }
    }
}
