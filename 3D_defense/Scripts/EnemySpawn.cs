using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    [Header("몹 스폰")]
    [SerializeField] GameObject Enemy_Spawn;
    [Header("스폰 위치")]
    [SerializeField] GameObject Spawn_position;
    [Header("스폰 위치2")]
    [SerializeField] GameObject Spawn_position2;
    bool end_1 = false;
    bool end_2 = false;
    bool end_3 = false;
    bool beg_1 = false;
    bool beg_2 = false;
    bool beg_3 = false;
    // Start is called before the first frame update
    public int cnt;

    public Text asdf;

    void Start()
    {
        beg_1 = true;
        Stage1();
    }
    void Stage1()
    {
        InvokeRepeating("Spawn", 5, 2.0f);
        asdf.text = "asdf";
        

    }
    void Stage2()
    {
        InvokeRepeating("Spawn", 1, 2.0f);
        

    }
    void Stage3()
    {
        InvokeRepeating("Spawn", 1, 2.0f);
       

    }

    void Spawn()
    {
        var clone = Instantiate(Enemy_Spawn, Spawn_position.transform.position, Quaternion.identity);
        cnt += 1;
        clone.GetComponent<EnemyData>().SetHp(1);
        Debug.Log(cnt);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void FixedUpdate()
    {
        if (cnt >= 5)
        {
            cnt = 0;
            CancelInvoke();

            if(beg_2==false)
            {
                end_1 = true;
            }
            else if(beg_3==false)
            {
                end_2 = true;
            }
        }
        if(end_1==true &&  beg_2==false)
        {
            beg_2 = true;
            Invoke("Stage2", 5);
            Debug.Log("stage2 start");


        }
        if (end_2 == true && beg_3 == false)
        {
            Invoke("Stage3", 5);
            Debug.Log("stage3 start");
            beg_3 = true;
        }

        //clone.GetComponent<Rigidbody>().AddForce(transform.forward * Bullet_Speed);
        //  clone.transform.position = Vector3.Lerp(Spawn_position.transform.position, Spawn_position2.transform.position, Time.deltaTime );



    }
}
