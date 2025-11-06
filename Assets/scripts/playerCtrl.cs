using UnityEngine;

public class playerCtrl : MonoBehaviour
{

    [SerializeField] GameObject TarEne;
    [SerializeField] GameObject TarOri;
    [SerializeField] GameObject Player;
    [SerializeField] Vector3 TarLocEne;
    [SerializeField] Vector3 TarLocOri;
    [SerializeField] Vector3 CurrLoc;
        
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        CurrLoc = Player.transform.position;



    }

    // Update is called once per frame
    void Update()
    {
        TarLocEne = TarEne.transform.position;
        TarLocOri = TarOri.transform.position;
        // 
        //Vector3 enemyDir = TarLocEne - CurrLoc;
        //Quaternion enemyVect = Quaternion.LookRotation(enemyDir);

        //transform.rotation = enemyVect;


        transform.LookAt(TarLocEne);
        transform.LookAt(TarLocOri);



    }
}
