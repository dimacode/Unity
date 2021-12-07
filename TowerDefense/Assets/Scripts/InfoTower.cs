using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTower : MonoBehaviour
{
    public Tower TowerValues = new Tower();
    
    private GameObject target;
    private GameMode gameMode;
    private GameObject bullet;
    private float reloads;
    private bool attack = false;
    // Start is called before the first frame update
    void Start()
    {
        gameMode = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameMode>();
        reloads = TowerValues.atkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (attack) {

            if (Vector3.Distance(transform.position, target.transform.position) <= TowerValues.Range) {

                if (reloads <= 0.0f) {

                    bullet = (GameObject)Instantiate(TowerValues.BulletPref, TowerValues.BulletSpawn.transform.position, Quaternion.identity);
                    bullet.GetComponent<Bullet>().Target = target;
                    bullet.GetComponent<Bullet>().Damage = TowerValues.Damage;
                    bullet.GetComponent<Bullet>().Speed = TowerValues.bltSpeed;
                    
                    reloads = TowerValues.atkSpeed;

                } else {
                    reloads -= Time.deltaTime;
                }
            } else {
                attack = false;
            }


            

        } else {

            foreach(GameObject obj in gameMode.GameUnits) {

                if (Vector3.Distance(transform.position, obj.transform.position) <= TowerValues.Range) {
                    target = obj;
                    attack = true;
                }
            }
        }
    }
}
