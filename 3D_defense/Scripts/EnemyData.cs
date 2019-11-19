using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    private int hp;
    public void SetHp(int Hp)
    {
        this.hp = Hp;
    }

    // Start is called before the first frame update

    public void decreaseHP(int damage) // damage만큼 체력을 깎는다.
    {
        this.hp -= damage;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
