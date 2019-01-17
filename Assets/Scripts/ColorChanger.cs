using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer r;

    private Color c;

    // Start is called before the first frame update
    void Start()
    {
        r.color = new Color(1,0,0);
    }

    void Update()
    {
        r.color = new Color(0.75f + (Mathf.Sin(4 * Time.time))/4f, 0, 0);
    }
}
