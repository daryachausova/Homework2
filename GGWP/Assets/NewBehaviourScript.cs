using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text HPUI;
    public float Speed = 10f;
    public int State = 1;
    public int HP = 100;
    public int a = 0;

    void OnTriggerStay(Collider Other)
    {
        a = a + 1;
        Pushing();
        Debug.Log("Соприкосновение! Соприкосновение с объектом длится уже " + a + " кадров!");
    }
    void OnTriggerEnter(Collider Other)
    {
        a = a + 1;
        Pushing();
        Debug.Log("Соприкосновение! Соприкосновение с объектом длится уже " + a + " кадров!");
    }

    void Pushing()
    {
        HP = HP - 1;
        if (HP <= 0)
        {
            State = 0;
            HP = 0;
        }
        HPUI.text = HP.ToString() + "%";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10 * Speed * Time.deltaTime);
        }

    }

    void Start()
    {
        int b = 15, c = 40;
        int d = b + c;
        Debug.Log("Здравствуй, мир! Складываю переменную b, которая равна " + b + ", и переменную c, которая равна " + c + ". Ответ равен: " + d + ".");
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
