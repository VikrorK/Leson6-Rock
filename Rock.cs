using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
   public float forceRock; //скорость/силу броска камня
    public float destroyTime=5f; //время удаления камня
    public AudioSource auds; //компонент audiosource
    Vector3 Lastpos; //позиция для последнего кадра
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); //добавляем переменную rigidbody
        Vector3 force = transform.up * forceRock; //создаем силу толчка камня 
        rb.AddForce(force);//даем импульс (толчек) для камня 
    }

    // Update is called once per frame
    void Update()
    {
        //Воиспроизводим звук при касание камня объектов через луч
      RaycastHit hit; 
        if(Physics.Linecast(Lastpos, transform.position, out hit)){
            auds.Play();
        }
        Lastpos=transform.position;
        
        Destroy();//удаляем камень
    }
/*
//Вариан проигрывания звука через колизию

    void OnCollisionEnter(){
        auds.Play();
        
    }
*/

  
    //функция удаления камня
    void Destroy(){
        destroyTime-=Time.deltaTime;//отнимаем время таймера
        if(destroyTime<=0){ //если время меньше или равно 0
            Destroy(gameObject); //удаляем объект со сцены
            
        }
    }
}
