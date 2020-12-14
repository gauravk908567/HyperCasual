using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnner : MonoBehaviour
{
    public GameObject Platform_Reg;
    public GameObject SlowSpeed;
    public GameObject[] Moving_Platform;
    public GameObject BreakablePlatform;


    public float Spawntimer = 2f;
    private float _current_SpawnTimer;
    private int _SpawnCount;
    public float min_X = -5.14f, max_X = +5.14f;

    void Start()
    {
        _current_SpawnTimer = Spawntimer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatform();
    }

    void SpawnPlatform()
    {
        _current_SpawnTimer += Time.deltaTime;

        if(_current_SpawnTimer>=Spawntimer)
        {
            _SpawnCount++;
            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            GameObject newplatform = null;

            if (_SpawnCount < 2)
            {
                newplatform = Instantiate(Platform_Reg, temp, Quaternion.identity);

            }
            else if (_SpawnCount == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplatform = Instantiate(Platform_Reg, temp, Quaternion.identity);
                }
                else
                {
                    newplatform = Instantiate(Moving_Platform[Random.Range(0, Moving_Platform.Length)], temp, Quaternion.identity);

                }
            }
            else if (_SpawnCount == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplatform = Instantiate(Platform_Reg, temp, Quaternion.identity);
                }
                else
                {
                    newplatform = Instantiate(SlowSpeed, temp, Quaternion.identity);

                }
            }

            else if (_SpawnCount == 4)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplatform = Instantiate(Platform_Reg, temp, Quaternion.identity);
                }
                else
                {
                    newplatform = Instantiate(BreakablePlatform, temp, Quaternion.identity);

                }

                _SpawnCount = 0;

            }

            newplatform.transform.parent = transform;
            _current_SpawnTimer = 0;

        }
    }


}//class
