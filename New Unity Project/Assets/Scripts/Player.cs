using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public float speed = 4f;
    public float force = 6f;
    // Плдключаем компо. Rigidbody2D который используем в Юнити для обьекта
    public Rigidbody2D ri_body;
    public float minHeight;
    public bool isCheetMode = false;

    
   

    // Update is called once per frame
    void Update() 
    {
        // int abc = 10;
        // Debug.Log(abc);
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log(4646544654564);
            // Vector2 - Обьект 2D приложение
            // Time - Time.deltaTime время которое прошло между двумя кадрами 
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        // GetKeyDown - когда клавиша еще нажата
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log(123);
            // FrorceMode2D - Тип прикладываемой силы (Force - постоянно | Impulse - моментно)
            ri_body.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }

        if (transform.position.y < minHeight) {

            if (isCheetMode) {
                Destroy(gameObject); // Удаляет игровой обьект
            }

            ri_body.velocity = new Vector2(x:0, y: 0); // Более плавная анимация получится
            transform.position = new Vector2(x: 0, y: 0);
            // transform.position = new Vector3(x: 0, y: 0, z:0);
        }
        
    }
}
