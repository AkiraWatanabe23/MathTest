using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// 2DƒIƒuƒWƒFƒNƒg‚ÌŽÎ–Ê‚ÌˆÚ“®
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

        Vector2 delta = transform.position - _target.position;
        float dot = Vector3.Dot(Mul(_target.position, Vector3.right), delta) / 
            Vector3.SqrMagnitude(Mul(_target.position, Vector3.right));

        if (dot < -1f)
        {
            dot = -1f;
        }
        else if (dot > 1f)
        {
            dot = 1f;
        }
        Vector3 minPos = Mul(_target.position, Vector3.right) * dot + _target.position;

        float sqr = Vector3.SqrMagnitude(minPos - transform.position);
        float arg = sqr * sqr;


        Vector2 pos = trans.position;
        pos.x += 0.01f * hol;

        trans.position = pos;
    }

    //Vector3“¯Žm‚ÌŠ|‚¯ŽZ
    public static Vector3 Mul(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
    }
}
