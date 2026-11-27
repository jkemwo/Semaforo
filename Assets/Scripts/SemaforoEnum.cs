using UnityEngine;

public class SemaforoEnum : MonoBehaviour
{
    public enum EstadoEnumSemaforo
    {
        enRojo,
        enVerde,
        enAmarillo
    }

    [SerializeField]
    EstadoEnumSemaforo estadoSemaforo = EstadoEnumSemaforo.enRojo;

    float timer = 0.0f;

    private void Start()
    {
        //Poner luces rojo
    }
    void Update()
    {
        switch (estadoSemaforo)
        {
            case EstadoEnumSemaforo.enRojo:
                EjecutaSemaforoRojo();
                break;
        }
    }

    void EjecutaSemaforoRojo()
    {
        if (timer > 10.0f)
        {
            //Poner luz en verde
            estadoSemaforo = EstadoEnumSemaforo.enVerde;
        }
    }
}
