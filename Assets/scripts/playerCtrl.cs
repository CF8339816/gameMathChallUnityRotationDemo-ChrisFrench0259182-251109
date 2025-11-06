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
        TarLocEne = TarEne.transform.position;
        TarLocOri = TarOri.transform.position;




    }

    // Update is called once per frame
    void Update()
    {

       transform.LookAt(TarLocEne);




    }
}
