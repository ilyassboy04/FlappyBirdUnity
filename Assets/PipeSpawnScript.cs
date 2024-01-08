using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 13;
    // Start is called before the first frame update
    void Start()
    {
         spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float tallestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(lowestPoint, tallestPoint), 0), transform.rotation);
    }
}
