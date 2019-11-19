using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    private GameObject target;


    void Start()
    {
        
    }
    
    void Update()
    {
        
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
            target.GetComponent<EnemyData>().decreaseHP(1);
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
            transform.rotation = Quaternion.Euler(0f,90f,0f);
            Debug.Log("resetangle");
        }
    }
}
