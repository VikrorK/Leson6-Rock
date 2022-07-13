using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockThrow : MonoBehaviour
{
    public Transform rockperf; //Перфаб камня
    public Transform SpaunPoint; //Точка спауна
  

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){ // Если нажали левую кнопку мыши
            Instantiate (rockperf, SpaunPoint.position, SpaunPoint.rotation); //создаем камень в точке спуна с его позициями
        }
    }
}
