using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public int distance;
    public E_boxtype e_boxtype;
    public GameObject[] box_预制体;
    private GameObject box_instance;
    private Vector3 boxpostion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            boxpostion=Input.mousePosition+Vector3.forward*distance;
            switch(e_boxtype)
            {
                case E_boxtype.cube:
                    box_instance = Instantiate(box_预制体[0]);
                    box_instance.transform.position = Camera.main.ScreenToWorldPoint(boxpostion);
                    break;
                case E_boxtype.sphere:
                    box_instance = Instantiate(box_预制体[1]);
                    box_instance.transform.position = Camera.main.ScreenToWorldPoint(boxpostion);
                    break;
                case E_boxtype.capsuale:
                    box_instance = Instantiate(box_预制体[2]);
                    box_instance.transform.position = Camera.main.ScreenToWorldPoint(boxpostion);
                    break;
            }
            Destroy(box_instance,2);
        }
    }

}
public enum E_boxtype
{
    sphere,
    cube,
    capsuale
}
