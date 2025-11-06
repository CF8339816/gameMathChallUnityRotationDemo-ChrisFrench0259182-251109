using UnityEngine;

public class scene2Orbiting : MonoBehaviour
{ 
    [SerializeField] int orbitSpeed = 3;
    [SerializeField] int deflection= 0;
    [SerializeField] int rotate = 0;
   // [SerializeField] GameObject centerTarget;
    [SerializeField] GameObject orbiter;

    //Vector3 startPosition;

void Start()
{

   // transform.position = startPosition;

}

// Update is called once per frame
void Update()
    {
        
        //Vector3 facetarget = centerTarget.transform.position;

       // Quaternion myOrbitVector = Quaternion.LookRotation(centerTarget);



    }
}
/*
 * 
 * need to make the orbiter go  forwaqrd but have it constreained to a set distance away from the center  target . i have no idea  how  to accomplish this 
 * alternaqtely i could have it just rotate  with an ofset  away from the object  in the cen ter with a  rotattetoface  thecenter with a very  small margine of  this movement that matched the  velocity  of the orbit or just behind  it 
 * i do  not get  the code and how  the math is  being utalized  . i know the theory somewhat but cannot apply it in any kinfd of  fiuntional manner . 
 * 
 * */

