using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 三角関数でFadeができるかテストしてみる
/// </summary>
public class MathFadeTest : MonoBehaviour
{
    [SerializeField] private Image _fade;
    [SerializeField] private bool _isFadeIn = false;
    [SerializeField] private bool _isFadeOut = false;
    float a = 0;

    private void Start()
    {
        a = _fade.GetComponent<Image>().color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFadeIn)
        {
            FadeIn(1.5f);
        }
        
        if (_isFadeOut)
        {
            FadeOut(1.5f);
        }
    }

    private void FadeIn(float interval)
    {
        float time = Time.time;
    }

    private void FadeOut(float interval)
    {

    }
}
