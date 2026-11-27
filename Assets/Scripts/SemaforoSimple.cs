using UnityEngine;

public class SemaforoSimple : MonoBehaviour
{
    [SerializeField]
    GameObject redLight;
    [SerializeField]
    GameObject ambarLight;
    [SerializeField]
    GameObject greenLight;

    [SerializeField]
    float timeinRed = 10f;
    [SerializeField]
    float timeingreen = 15f;
    [SerializeField]
    float timeinambar = 2f;

    float contador = 0f;
    void Start()
    {
        EncenderLuces(false, false, true);
    }

    void EncenderLuces(bool greenStatus, bool ambarStatus, bool redStatus)
    {
        redLight.SetActive(redStatus);
        greenLight.SetActive(greenStatus);
        ambarLight.SetActive(ambarStatus);
        
    }

    void Update()
    {
        contador += Time.deltaTime;

        if (contador >= timeinRed && redLight.activeSelf == true)
        {
            EncenderLuces(true, false, false);
            contador = 0f;
        }
        else if (contador>= timeingreen && greenLight.activeSelf == true){
            EncenderLuces(false, true, false);
            contador = 0.0f;
        }
        else if (contador>= timeinambar && ambarLight.activeSelf == true)
        {
            EncenderLuces(false, false, true);
            contador = 0.0f;
        }

    }
}
