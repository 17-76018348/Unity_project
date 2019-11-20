using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    float x = 0;
    float z = 0;
    int pos_x = 0;
    int pos_z = 0;
    public int gold = 100;
    public Vector3 Spawn_Position;
    public GameObject fakeTurret;
    [Header("가짜터렛")]
    [SerializeField] GameObject FakeTurret;
    [Header("Lv1turret")]
    [SerializeField] GameObject Turret1;
    [Header("Lv1turret")]
    [SerializeField] GameObject Turret2;
    [Header("스폰 위치")]
    [SerializeField] GameObject Turret_position;
    public bool fake = false;
    // Start is called before the first frame update
    // Start is called before the first frame update
    public int[,] array = new int[8, 8] { { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0 } };

    void Start()
    {
        
    }
    float Abs(float num)
    {
        if(num>=0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void Position()
    {
        Spawn_Position = this.transform.position;

        Spawn_Position.y = 0.1f;
        x = Spawn_Position.x % 10;
        z = Spawn_Position.z % 10;


        if (Abs(x) >= 5)
        {
            if (x >= 0)
            {
                Spawn_Position.x = Spawn_Position.x - (x - 5);
            }
            else
            {
                Spawn_Position.x = Spawn_Position.x - (x + 5);
            }
        }
        else if (Abs(x) < 5)
        {
            if (x >= 0)
            {
                Spawn_Position.x = Spawn_Position.x + (5 - x);

            }
            else
            {
                Spawn_Position.x = Spawn_Position.x - (5 + x);
            }
        }
        if (Abs(z) >= 5)
        {
            if (z >= 0)
            {
                Spawn_Position.z = Spawn_Position.z - (z - 5);
            }
            else
            {
                Spawn_Position.z = Spawn_Position.z - (z + 5);
            }
        }

        else if (Abs(z) < 5)
        {
            if (z >= 0)
            {
                Spawn_Position.z = Spawn_Position.z + (5 - z);
            }
            else
            {
                Spawn_Position.z = Spawn_Position.z - (5 + z);
            }
        }

        pos_x = (((int)Spawn_Position.x) + 35) / 10;
        pos_z = (((int)Spawn_Position.z) + 35) / 10;

    }
    void FakePlace()
    {
        Position();
        if (array[pos_x, pos_z] == 0)
        {
            //var fak_clone = Instantiate(FakeTurret, Spawn_Position, Quaternion.identity);
            fakeTurret.transform.position = Spawn_Position;
            fake = true;

            //gold -= 3;
        }

        
    }

    public void Button1Click()
    {
        if(gold>=3)
        {
            FakePlace();
            Debug.Log("Asdf");

        }
    }
    public void Button2Click()
    {
        Position();
        if(gold>=3 && fake == true && array[pos_x, pos_z]==0)
        {
            //Destroy(GameObject.Find("Capsule(Clone)"));
            fakeTurret.transform.position = new Vector3(0, -100, 0);
            var tur = Instantiate(Turret1, Spawn_Position, Quaternion.identity);
            fake = false;
            gold -= 3;
            array[pos_x, pos_z] = 1;
        }
    }
    public void Button3Click()
    {
        Position();
        if (gold >= 3 && fake == true && array[pos_x,pos_z]==0)
        {
            //Destroy(GameObject.Find("Capsule(Clone)"));
            fakeTurret.transform.position = new Vector3(0, -100, 0);
            var tur = Instantiate(Turret2, Spawn_Position, Quaternion.identity);
            fake = false;
            gold -= 3;
        }
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.P) && gold>=3)
        {
            FakePlace();
            fake = true;

        }
        
        
       
        if(Input.GetKeyDown(KeyCode.R) && gold>=3 && fake == true)
        {

            Destroy(GameObject.Find("Capsule(Clone)"));
            var tur = Instantiate(Turret, Spawn_Position, Quaternion.identity);
            fake = false;
            gold -= 3;
        }
        */

    }
}
