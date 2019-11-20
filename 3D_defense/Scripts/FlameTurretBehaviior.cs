using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTurretBehaviior : MonoBehaviour
{
    private GameObject target;
    Quaternion quater;
    float turretAngle;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        this.damage = 2;
    }
    void Looktarget()
    {
        transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));

    }
    public void OnTriggerEnter(Collider other)
    {
        target = other.gameObject;
        if (target.tag == "Enemy")
        {
            target.GetComponent<EnemyData>().decreaseHP(damage);
            Debug.Log("hp-1");
        }
    }
    public void OnTriggerStay(Collider other1)
    {
        if (other1.gameObject.name == "Enemy(Clone)")
        {
            target = other1.gameObject;
            Looktarget();


        }
    }
    public void OnTriggerExit(Collider other2)
    {
        if (other2.gameObject == target)
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            Debug.Log("resetangle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        turretAngle += 270.0f * Time.deltaTime;
        quater.eulerAngles = new Vector3(0, turretAngle, 0f);
        this.transform.rotation = quater;
    }
}
