using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTurretBehaviior : MonoBehaviour
{
    Quaternion quater;
    float turretAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turretAngle += 270.0f * Time.deltaTime;
        quater.eulerAngles = new Vector3(0, turretAngle, 0f);
        this.transform.rotation = quater;
    }
}
