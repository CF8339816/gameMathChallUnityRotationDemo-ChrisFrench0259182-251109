using UnityEngine;

public class Scene2yRotatrion : MonoBehaviour
{


    [SerializeField] int speed = 3;
    [SerializeField] int deflection = 120;
   // [SerializeField] int rotate = 3;

    Vector3 startPosition;

    void Start()
    {

        transform.position = startPosition;
      
    }

    // Update is called once per frame
    void Update()
    {//Time.time
       
        transform.eulerAngles = new Vector3(0 ,deflection * Mathf.Sin(Time.time * speed), 0);


    }
}

//using UnityEditor.ShaderGraph.Internal;
//using UnityEngine;

//public class plat1movementscript : MonoBehaviour
//{
//    [SerializeField] int speed = 3;
//    [SerializeField] int slide = 0;
//    [SerializeField] int height = 3;

//    Vector3 startPosition;

//    void Start()
//    {

//        // transform.position = startPosition;
//        transform.position = new Vector3(-21, 7, -6);
//    }

//    // Update is called once per frame
//    void Update()
//    {//Time.time
//        //transform.position = new Vector3(-20 + 15 * Mathf.Sin(Time.time * speed), 4 + 20 * Mathf.Sin(Time.time * height), -6);
//        transform.position = new Vector3(-21 + 16 * Mathf.Sin(Time.time * speed), 7 + 8 * Mathf.Sin(Time.time * height), -6);


//    }
//}

