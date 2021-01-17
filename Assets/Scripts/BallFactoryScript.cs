using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        // インスタンス生成（プレハブからGameObjectを生成する）
        // Instantiate(ball, transform.position, transform.rotation);

        // InvokeRepeating
        // 一定時間ごとに指定した命令を実行する
        //
        // 第一引数：関数名
        // 第二引数：ゲーム開始からn秒後に実行する
        // 第三引数：n秒ごとに実行する
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    void SpawnBall()
    {
        // Instantiate
        // 第一引数：プレハブの名前
        // 第二引数：表示位置
        // 第三引数：回転
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
