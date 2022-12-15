using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// 2Dオブジェクトの斜面の移動
/// </summary>
public class SlopeMove2D : MonoBehaviour
{
    [Range(1f, 10f)]
    [SerializeField] private float _moveSpeed = 1f;
    [Range(1f, 10f)]
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private Transform _target;

    void Update()
    {
        var hol = Input.GetAxisRaw("Horizontal");
        Transform trans = transform;
        
        Vector2 pos = trans.position;
        pos.x += 0.01f * hol;

        trans.position = pos;
    }
}
