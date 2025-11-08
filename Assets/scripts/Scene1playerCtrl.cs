using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Scene1playerCtrl : MonoBehaviour
{

    [SerializeField] GameObject TarEne;
    [SerializeField] GameObject TarOri;
    [SerializeField] GameObject Player;
    [SerializeField] Vector3 TarLocEne;
    [SerializeField] Vector3 TarLocOri;
    [SerializeField] Vector3 pCurrLoc;
    [SerializeField] float SlerpEase = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pCurrLoc = Player.transform.position;
        //Quaternion pCurrLocY = Player.transform.rotation; 
        //Vector3 pCurrLocX = Player.Rotation.x;

    }

    // Update is called once per frame
    void Update()
    {  /*
        * cannot get the player to follow both only one or the other 
        * all tutorials i look at are all setting the follow once to a midpoint between the two  look objects
        *  i don't believe that is what you are looking for so there will only be one path followed when i hand this in 
        *  unless i get a stroke of brillance by sunday afternoon
        *  i know i am missing something but am at a loss to define what that is.
        */

        if (TarLocEne != null && TarLocOri != null)
        {

            TarLocOri = TarOri.transform.position; //direction to orientation target.
            Vector3 OriDir = TarLocEne - pCurrLoc;
            Quaternion OriVect = Quaternion.LookRotation(OriDir);

            transform.rotation = OriVect;
            // transform.LookAt(TarLocOri);  //  follow orientation object position

            TarLocEne = TarEne.transform.position; //directon to enemy target.
            Vector3 enemyDir = TarLocEne - pCurrLoc;
            Quaternion enemyVect = Quaternion.LookRotation(enemyDir);

            transform.rotation = enemyVect;
            // transform.LookAt(TarLocEne);  // follow  enemy object location

        }


    }
}
