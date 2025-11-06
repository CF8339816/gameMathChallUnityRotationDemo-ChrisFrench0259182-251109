using UnityEngine;

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
    {
       

        TarLocEne = TarEne.transform.position; //directon to enemy target.
            Vector3 enemyDir = TarLocEne - pCurrLoc;
            Quaternion enemyVect = Quaternion.LookRotation(enemyDir);

            transform.rotation = enemyVect;
       

       
        TarLocOri = TarOri.transform.position; //direction to orientation target.
            Vector3 OriDir = TarLocEne - pCurrLoc;
            Quaternion OriVect = Quaternion.LookRotation(OriDir);

            transform.rotation = OriVect;
        
        // transform.LookAt(TarLocEne);  // follow  enemy object location

        // transform.LookAt(TarLocOri);  //  follow orientation object position



    }
}
