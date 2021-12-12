using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoUnit : MonoBehaviour
{
    public Unit Value = new Unit(); // Наследуем Unit что бы задавать каждому юниту свои параметры

    private int key = 0; // Будет содержать текущий поинтер
    private bool move = true;
    private Vector3 screenPos;
    private Rect backRect, colorRect;
    private GameMode gameMode; // Задаем тип тега который закреплен на елементе GameWorld
    private GameHUD gameHud;

    void Start() {
        Value.Health = Value.CurrentHealth;
        gameMode = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameMode>(); // Находим элемент по тегу GameMode
        gameHud = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameHUD>();
    }

    void Update() {

        if (move) {

            if (key <= gameMode.Areas.Count - 1) { // Отсчет кол-во поинтеров

                if (Vector3.Distance(transform.position, gameMode.Areas[key].transform.position) > 0.0f) { // Находим растояние между текущим Unit и Поинтером на карте

                    transform.position = Vector3.MoveTowards(transform.position, gameMode.Areas[key].transform.position, Value.Speed * Time.deltaTime);
                    // Используем Vector3.MoveTowards метод, который принимает
                    // Текущую позицию юнита (transform.position)
                    // Позицию точки куда двигатся (gameMode.Areas[key].transform.position) 
                    // Скорость передвижения (Value.Speed * Time.deltaTime)

                } else {
                    key++;
                }

            } else {
                move = false; 
            }

        } else {
            gameMode.LosesUnits++;
            
            gameMode.GameUnits.Remove(transform.gameObject);
            Destroy(transform.gameObject);
            
        }

        if (Value.CurrentHealth <= 0) {
            gameMode.Diamonds += Value.Diamonds;
            
            gameMode.GameUnits.Remove(transform.gameObject);
            Destroy(transform.gameObject);
        }
    }

    // void OnGUI() {
    //     screenPos = Camera.main.WorldToScreenPoint(transform.position);
    //     backRect = new Rect(screenPos.x - 25, Screen.height - (screenPos.y + 20), 50, 10);
    //     colorRect = new Rect(screenPos.x - 25, Screen.height - (screenPos.y + 20), 50 * (Value.CurrentHealth / Value.Health), 10);
    //     GUI.DrawTexture(backRect, gameHud.skin.GetStyle("HealthBar").normal.background);
    //     GUI.DrawTexture(colorRect, gameHud.skin.GetStyle("HealthBar").active.background);
    // }
}
