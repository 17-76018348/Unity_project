using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public Transform tf;
    public Text text1;
    public Text text2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = tf.position.x.ToString();
        text2.text = tf.position.z.ToString();
    }
}
