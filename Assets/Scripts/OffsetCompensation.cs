using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetCompensation : MonoBehaviour
{
    public GameObject parent;
    public Vector3 Rotation;
    public bool flipXandZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion tempRotation = parent.transform.rotation * Quaternion.Euler(Rotation.x, Rotation.y, Rotation.z);
        if (flipXandZ)
        {
            transform.rotation = Quaternion.identity *
                            Quaternion.AngleAxis(tempRotation.eulerAngles.y, Vector3.up);
        } else
        {
            transform.rotation = Quaternion.identity *
                            Quaternion.AngleAxis(tempRotation.eulerAngles.y, Vector3.up) *
                            Quaternion.AngleAxis(tempRotation.eulerAngles.z, Vector3.forward) *
                            Quaternion.AngleAxis(tempRotation.eulerAngles.x, Vector3.right);
        }
        this.transform.position = parent.transform.position;
    }
}
