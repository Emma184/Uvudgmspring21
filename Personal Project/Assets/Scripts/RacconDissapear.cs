using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacconDissapear : MonoBehaviour
{
    private float raccoonLifetime;
    private float enemyCount;
    public float enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, DeleteEnimies());
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<en>().Length;
        // tells it when it can spawn enemies, with increasing number 
        
        void DeleteEnemies()
        {
           
            if(enemyCount == 1)
            Destroy(gameObject); 
            IEnumerator PowerupCountdownRoutine()
            {
                yield return new WaitForSeconds(20);
               

            }
        }

    }
}

