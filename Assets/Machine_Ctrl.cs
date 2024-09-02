using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine_Ctrl : MonoBehaviour
{
    public GameObject push_machine;
    public GameObject push_machine1;
    public GameObject push_machine2;
    public GameObject push_machine3;
    public GameObject push_machine4;
    public GameObject push_machine5;
    public GameObject Goal_Plate;
    public Vector3 start_PunchM_point;
    public Vector3 start_MovingM_point;
    public static int Play_Credit=0;
    public static bool Coin_Marker;
    private Vector3 x_position;
    private Vector3 Machine_1_startPosition;
    private Vector3 y_end_position;
    public GameObject machine_1;
    public AudioClip coinSound;
    private AudioSource audioSource;
    public float timer = 0.0f;
    public float punch_timer = 0.0f;
    public bool push_end = false;

    // Start is called before the first frame update
    void Start()
    {
        Coin_Marker = false;
        start_MovingM_point = machine_1.transform.position;
        start_PunchM_point = push_machine5.transform.position;
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        InsertCoin();
        if (Play_Credit >= 1)
        {
            Debug.Log(Play_Credit);
            if (Marker_Ctrl.LeftMarker==true)
            {
                Debug.Log("LMarkerOn");
                if ((push_machine.transform.position.z >= -27.0f) && (push_machine.transform.position.z <= 0.11f))
                {
                    push_machine.transform.position += new Vector3(0.0f, 0.0f, -0.05f);
                    machine_1.transform.position += new Vector3(0.0f, 0.0f, -0.05f);
                }
            }
            if (Marker_Ctrl.LeftMarker == false)
            {
                Debug.Log("LMarkerOff");
            }

                if (Marker_Ctrl.UpMarker)
            {
                if ((push_machine.transform.position.y <= 29.0f) && (push_machine.transform.position.y >= -0.1f))
                {
                    push_machine.transform.position += new Vector3(0.0f, 0.05f, 0.0f);
                }
            }

            push();
        }
    }

    void reset_machine_position()
    {
        timer = timer + Time.deltaTime;
        while (machine_1.transform.position.z <= 13.5f)
        {
            machine_1.transform.position += new Vector3(0.0f, 0.0f, 0.05f);
            push_machine.transform.position += new Vector3(0.0f, 0.0f, 0.05f);
        }
        while((push_machine.transform.position.y <= 29.5f) && (push_machine.transform.position.y >= 0f))
        {
            push_machine.transform.position += new Vector3(0.0f, -0.05f, 0.0f);
        }

        if ((push_machine1.transform.position.x >= -12.5f) && (push_machine1.transform.position.x <= 0.0f))
        {
            push_machine1.transform.position += new Vector3(0.05f, 0.0f, 0.0f);
        }
        if ((push_machine2.transform.position.x >= -9.5f) && (push_machine2.transform.position.x <= 0.0f))
        {
            push_machine2.transform.position += new Vector3(0.05f, 0.0f, 0.0f);
        }
        if ((push_machine3.transform.position.x >= -6.5f) && (push_machine3.transform.position.x <= 0.0f))
        {
            push_machine3.transform.position += new Vector3(0.05f, 0.0f, 0.0f);
        }
        if ((push_machine4.transform.position.x >= -3.5f) && (push_machine4.transform.position.x <= 0.0f))
        {
            push_machine4.transform.position += new Vector3(0.05f, 0.0f, 0.0f);
        }
        push_machine.transform.position = start_PunchM_point;
        push_machine5.transform.position = start_PunchM_point;
        push_machine4.transform.position = start_PunchM_point;
        push_machine3.transform.position = start_PunchM_point;
        push_machine2.transform.position = start_PunchM_point;
        push_machine1.transform.position = start_PunchM_point;
        if(timer >= 3.0f)
        {
            push_end = false;
            Play_Credit -= 1;
            timer = 0.0f;
            punch_timer = 0.0f;
        }
             
    }
    public void InsertCoin()
    {
        if(Coin_Marker == false)
        {
            if (Marker_Ctrl.CoinMarker)
            {
                Play_Credit += 1;
                audioSource.PlayOneShot(coinSound);
                Coin_Marker = true;
            }
        }       
    }  
    public void push()
    {
        if (Marker_Ctrl.PushMarker)
        {
            punch_timer += Time.deltaTime;
            if ((push_machine4.transform.position.x >= -3.0f) && (push_machine4.transform.position.x <= 1.0f))
            {
                push_machine4.transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
            }
            if ((push_machine3.transform.position.x >= -6.0f) && (push_machine3.transform.position.x <= 0.1f))
            {
                push_machine3.transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
            }
            if ((push_machine2.transform.position.x >= -9.0f) && (push_machine2.transform.position.x <= 0.1f))
            {
                push_machine2.transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
            }
            if ((push_machine1.transform.position.x >= -12.0f) && (push_machine1.transform.position.x <= 0.1f))
            {
                push_machine1.transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
            }
            if((push_machine1.transform.position.x <= -12.0f)&&(punch_timer>=2.5f))
            {
                push_end = true;
            }
        }
        
        if(push_end)
        {
            reset_machine_position();
        }
    }
}
 