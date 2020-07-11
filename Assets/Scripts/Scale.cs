using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    Vector2 minScale;
    public Vector2 maxScale;
    public bool repeatable;
    public float speed = 2f;
    public float duration = 5f;

    IEnumerator Start()
    {
        minScale = transform.localScale;
        while (repeatable)
        {
            yield return RepeatLerp(minScale, maxScale, duration);
            yield return RepeatLerp(maxScale, minScale, duration);
        }
    }

    public IEnumerator RepeatLerp(Vector2 a, Vector2 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector2.Lerp(a, b, i);
            yield return null;
        }
    }
}
