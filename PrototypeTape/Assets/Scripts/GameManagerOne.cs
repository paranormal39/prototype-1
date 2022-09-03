using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerOne : MonoBehaviour
{
    public enum state {menu,play,gameover};
    public state current;

    public float gametimer;
    public float timer1;

    
    // Start is called before the first frame update
    void Start()
    {
        timer1 =3f;
    }

    // Update is called once per frame
    void Update()
    {
        gametimer += Time.deltaTime;
        switch (current)
        {
            case state.menu:

            break;

            case state.play:
            timer1 -= Time.deltaTime;

            if(timer1 <=0.1){
                //do somthing
                timer1 =3f;
            }
            break;
            case state.gameover:

            break;
            
            }
        
    }
}
