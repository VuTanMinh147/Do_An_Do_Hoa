using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public bool offsetvalue;
    public float rotateSpeed;
    public Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        if(!offsetvalue)
        {
            offset = target.transform.position - transform.position;
            pivot.transform.position = target.transform.position;
            pivot.transform.parent = target.transform;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //l?y v? tri cua chuot va xoay muc tieu
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.transform.Rotate(-vertical, 0, 0);
        //fix loi quay va khi quay zoom vao nhan vat
        if(pivot.rotation.eulerAngles.x > 45f && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(45f, 0, 0);
        }
        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 315f)
        {
            pivot.rotation = Quaternion.Euler(315f, 0, 0);
        }

        // di chuyen may anh dua tren goc quay hien tai va goc lech ban dau
        float Yangle = target.transform.eulerAngles.y;
        float Xangle = pivot.transform.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(Xangle, Yangle, 0);
        transform.position = target.transform.position - (rotation * offset);

        //cam xuong dat
        if(transform.position.y < target.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.transform.position.y, target.transform.position.z);
        }

        transform.LookAt(target.transform);
    }
}
