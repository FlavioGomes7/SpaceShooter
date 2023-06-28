using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Effect : MonoBehaviour
{
    MeshRenderer rt;
    Material mat;
    Vector2 offSet; 
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<MeshRenderer>();
        mat = rt.material ;
        offSet = mat.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        offSet.Set(-transform.position.x, -transform.position.y);
        mat.mainTextureOffset = offSet / 5;
    }
}
