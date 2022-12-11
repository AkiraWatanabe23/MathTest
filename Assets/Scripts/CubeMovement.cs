using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [Tooltip("移動量")]
    [SerializeField] private float _moveValue = 0;

    // Update is called once per frame
    void Update()
    {
        //Mathf.Deg2Rad -> 「度(°)」を「ラジアン(rad)」に変換する
        float rad = Time.time * Mathf.Deg2Rad;

        //三角関数「Sin, Cos」
        //-1 ～ 1 の値を返す
        float sin = Mathf.Sin(rad);
        float cos = Mathf.Cos(rad);

        //左右方向の動き
        //transform.position =
        //    new Vector3(cos * _moveValue, 0, 0);
        //上下方向の動き
        //transform.position = 
        //    new Vector3(0, sin * _moveValue, 0);
        //円運動(反時計回り)
        transform.position =
            new Vector3(cos * _moveValue, sin * _moveValue, 0);
    }
}
