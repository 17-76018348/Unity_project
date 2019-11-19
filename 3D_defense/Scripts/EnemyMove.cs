using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject target;
    public GameObject[] targetPosition;
    public GameObject player;
    public Quaternion quater;
    public bool circle;
    public Vector3 direction;
    public int life = 10;
    void Start()
    {
        quater = Quaternion.identity;
        direction = new Vector3(0, 0, 1);
        Debug.Log("Phase 1");
        //player = GameObject.Find("Player");
        //InvokeRepeating("LookPlayer", 1, 0.5f);
    }

    /* void Awake()
     {
         targetPosition = new GameObject[4];
         targetPosition[0] = GameObject.Find("TargetPosition1");
         targetPosition[1] = GameObject.Find("TargetPosition2");
         targetPosition[2] = GameObject.Find("TargetPosition3");
         targetPosition[3] = GameObject.Find("TargetPosition4");
         target = targetPosition[0];
         LookTarget();
         //player = GameObject.Find("Player");
         //InvokeRepeating("LookPlayer", 1, 0.1f);
     }

     void LookTarget()
     {
         transform.LookAt(target.transform.position);//new Vector3(target.transform.position.x, 0, target.transform.position.z));
     }*/
 
    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.name == "TargetPosition1")// == targetPosition[0])
        {
            
            quater.eulerAngles += new Vector3(0, -90, 0);
            transform.rotation = quater;
            Debug.Log("Phase 2");
            circle = true;
        }
        else if (col.gameObject.name == "TargetPosition2")// == targetPosition[1])
        {
            
            quater.eulerAngles += new Vector3(0, -90, 0);
            transform.rotation = quater;
            Debug.Log("Phase 3");
        }
        else if (col.gameObject.name == "TargetPosition3")// == targetPosition[2])
        {
            quater.eulerAngles += new Vector3(0, -90, 0);
            transform.rotation = quater;
            Debug.Log("Phase 4");
        }
        else if (col.gameObject.name == "TargetPosition4" && circle)// == targetPosition[3])
        {
            quater.eulerAngles += new Vector3(0, -90, 0);
            transform.rotation = quater;
            Debug.Log("Life -1");
            life--;
            Debug.Log(life);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Translate(12.0f * transform.forward * Time.deltaTime, Space.World);
        transform.Translate(12.0f * direction * Time.deltaTime, Space.Self);

    }
}
