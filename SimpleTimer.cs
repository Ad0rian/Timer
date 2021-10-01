using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent m_MyEvent;
    public float targetTime;

    private float counterTime;

    private void Start()
   {
      counterTime= targetTime;
   }

    void Update(){
 
   counterTime -= Time.deltaTime;
   
   if (counterTime <= 0.0f)
      {
         timerEnded();
      }
   }
   
   void timerEnded()
   {
      m_MyEvent.Invoke();
      counterTime= targetTime;
      gameObject.SetActive(false);
   }

   }
