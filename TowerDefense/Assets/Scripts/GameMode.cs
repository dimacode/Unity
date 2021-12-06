using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public int CountWave;
    public int CurWave;
    
    public List<GameObject> GameUnits = new List<GameObject>();
    public List<Wave> Waves = new List<Wave>();
    public List<GameObject> Areas = new List<GameObject>();

    private float timeWave = 10.0f;
    private float timeUnit = 1.0f;
    private int key;
    private bool created = true;



    void Start() {
        CountWave = Waves.Count;
        CurWave = 0;


    }

    void Update() {
        if (timeWave <= 0.0f && created) {
            if (CurWave <= CountWave -1) {
                if (timeUnit <= 0.0f) {
                    if (key <= Waves[CurWave].Units.Count - 1) {
                        UnityEngine.Debug.Log("Spawn unit");
                        GameUnits.Add((GameObject)Instantiate(Waves[CurWave].Units[key], Areas[0].transform.position, Quaternion.identity));
                        key++;
                        timeUnit = 1.0f;
                    } else {
                        CurWave++;
                        key = 0;
                        timeWave = 10.0f;
                        timeUnit = 1.0f;
                    }
                } else {
                    timeUnit -= Time.deltaTime;
                }
            } else {
                UnityEngine.Debug.Log("Level Complite");
                created = false;
            }
        } else {
            timeWave -= Time.deltaTime;
        }
    }
}
