using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngresarNumero : MonoBehaviour
{
    public TextMeshProUGUI txt_resultado;
    public TMP_InputField numero;
    public float cuenta;
    public int click;

    // Start is called before the first frame update
    void Start()
    {
        txt_resultado.gameObject.SetActive(false);
    }


    public void Operation()
    {
        cuenta = float.Parse(numero.text);
        click = click +1;
        if (cuenta < 0){
            txt_resultado.text = ("La cuenta tiene como resultado un número menor que cero. Ingresar otro número");
        }
        else {
            if (click > cuenta) {
                txt_resultado.text = ("La cuenta tiene como resultado un número menor que cero. Ingresar otro número");
            }else {
                cuenta = cuenta - click ;
                txt_resultado.text = ("El numero ingresado degradado uno es: " + cuenta);
            }
        }
        
        txt_resultado.gameObject.SetActive(true);
    }
}
