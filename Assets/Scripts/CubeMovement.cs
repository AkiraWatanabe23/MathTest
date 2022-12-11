using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [Tooltip("�ړ���")]
    [SerializeField] private float _moveValue = 0;

    // Update is called once per frame
    void Update()
    {
        //Mathf.Deg2Rad -> �u�x(��)�v���u���W�A��(rad)�v�ɕϊ�����
        float rad = Time.time * Mathf.Deg2Rad;

        //�O�p�֐��uSin, Cos�v
        //-1 �` 1 �̒l��Ԃ�
        float sin = Mathf.Sin(rad);
        float cos = Mathf.Cos(rad);

        //���E�����̓���
        //transform.position =
        //    new Vector3(cos * _moveValue, 0, 0);
        //�㉺�����̓���
        //transform.position = 
        //    new Vector3(0, sin * _moveValue, 0);
        //�~�^��(�����v���)
        transform.position =
            new Vector3(cos * _moveValue, sin * _moveValue, 0);
    }
}
