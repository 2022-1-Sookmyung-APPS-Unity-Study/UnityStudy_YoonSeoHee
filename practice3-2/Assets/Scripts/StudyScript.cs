using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            float rand = Random.Range(0.0f, 0.5f);
            this.transform.position = new Vector3(0.0f, 1.0f, rand);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 2.0f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float rand = Random.Range(0.0f, 360.0f);
            this.transform.rotation = Quaternion.Euler(rand, 0, 0f);
        }

        if (Input.GetKey(KeyCode.R)) // 좌회전
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.L)) // 우회전
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            float rand = Random.Range(0.5f, 2.0f);
            this.transform.localScale = new Vector3(rand, rand, rand);
        }

    }
}
