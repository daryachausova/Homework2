using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 10f;
    public int State = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10 * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10 * Speed * Time.deltaTime);
        }

    }
    public void Button()
    {
        if (State == 1)
        {
            State = 0;
            var renderer = this.gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("Transparent/Diffuse");
            renderer.material.color = Color.white * 0.25f;
            Speed = 0f;
        }
        else if (State == 0)
        {
            State = 1;
            var renderer = this.gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("Transparent/Diffuse");
            renderer.material.color = Color.white * 1.0f;
            Speed = 10f;
        }

    }
}
