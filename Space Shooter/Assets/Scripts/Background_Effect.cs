using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Effect : MonoBehaviour
{
    CanvasRenderer rt;
    Material mat;
    Vector2 offSet; 
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<CanvasRenderer>();
        mat = rt.GetMaterial();
        offSet = mat.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        offSet.x += Time.deltaTime;
        mat.mainTextureOffset = offSet;
    }
}
