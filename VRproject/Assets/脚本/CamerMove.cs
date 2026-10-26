using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class CamerMove : MonoBehaviour
{
    public Transform camera;
    public float Zoffset;
    public float Yoffset;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward* Time.deltaTime*10*Input.GetAxis("Vertical"));
        this.transform.Rotate(Vector3.up, Time.deltaTime*30*Input.GetAxis("Horizontal"));
    }
    private void LateUpdate()
    {
        
        camera.RotateAround(transform.position,Vector3.up,Time.deltaTime*100*Input.GetAxis("Mouse X"));
    }
}
