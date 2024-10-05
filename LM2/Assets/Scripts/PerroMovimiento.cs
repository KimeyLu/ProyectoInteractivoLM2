using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;


public class PerroMovimiento : MonoBehaviour
{   
    public float velocidad = 2f;

    GameObject banco; // Variables para los GameObjects "banco", "comedor", "universidad"
    GameObject comedor; 
    GameObject universidad; 
    Transform bancoTransform; // Obtiene los componentes transform (con pos,rot,escala)
    Transform comedorTransform;
    Transform universidadTransform; 
    CliquearLugar cliquearBanco; // referencia a los script para los objetos "Banco", "Comedor", "Universidad"
    CliquearLugar cliquearComedor; 
    CliquearLugar cliquearUniversidad; 
    
    Vector3 posActual;

    void Start()
    {
        banco = GameObject.FindWithTag("Banco"); //obtiene gameobject
        bancoTransform = banco.GetComponent<Transform>(); //componente transform
        cliquearBanco = banco.GetComponent<CliquearLugar>(); // Script CliquearLugar
        
        comedor = GameObject.FindWithTag("Comedor"); //obtiene gameobjec
        comedorTransform = comedor.GetComponent<Transform>(); //componente transform
        cliquearComedor = comedor.GetComponent<CliquearLugar>(); // Script CliquearLugar

        universidad = GameObject.FindWithTag("Universidad"); //obtiene gameobject
        universidadTransform = universidad.GetComponent<Transform>(); //componente transform
        cliquearUniversidad = universidad.GetComponent<CliquearLugar>(); // Script CliquearLugar

        //

        posActual = transform.position; // Posición inicial de los perros
    }

    void Update()
    {
        if (cliquearBanco.seHizoClick && gameObject.CompareTag("perroA")) 
        {    
  
                posActual = bancoTransform.position; 
            
        } else if (cliquearComedor.seHizoClick && gameObject.CompareTag("perroB")) 
        {     

                posActual = comedorTransform.position;

        } else if (cliquearUniversidad.seHizoClick) 
        {   //la idea aca es que todos los perros vayan a la universidad 
            if (gameObject.CompareTag("perroA") && gameObject.CompareTag("perroB"))
            {   
                posActual = universidadTransform.position; 
            }
        }

        // Mueve el perro hacia la posición Actual. MoveTowards(Inicio, Meta, velocidad); 
        transform.position = Vector3.MoveTowards(transform.position, posActual, velocidad * Time.deltaTime); 
    }
}
