using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // private float speed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Update()は画面が描画されるたびに実行されるため、
        // 実行するマシンのスペックによって実行回数が異なってくる、という問題がある
        //
        // それを解決する方法として Time.deltaTime を使うと良い
        // -> 遅いマシンでは大きな値、速いマシンでは小さな値をかけてくれる
        //   -> 結果としてどのマシンでも同じ速度になる
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        // Debug.Log(transform.position.x);
    }
}
