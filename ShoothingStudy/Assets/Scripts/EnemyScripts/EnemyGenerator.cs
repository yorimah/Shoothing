using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    int _geneSpan = 1;

    float _geneSpanCount = 0;

    int _geneRnd;
    float _enemyInsRnd;

    [SerializeField]
    GameObject Enemy_Rush;
    [SerializeField]
    GameObject Enemy_Shot;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _geneSpanCount += Time.deltaTime;
        if(_geneSpanCount > _geneSpan)
        {
            _geneRnd = Random.Range(0, 2);
            switch (_geneRnd)
            {
                case 0:
                    _enemyInsRnd = Random.Range(-15, 15);
                    Instantiate(Enemy_Rush, new Vector3(_enemyInsRnd, 5),Quaternion.identity);
                    break;
                case 1:
                    _enemyInsRnd = Random.Range(-5, 5);
                    Instantiate(Enemy_Shot, new Vector3(_enemyInsRnd, 5), Quaternion.identity);
                    break;
                default:
                    Debug.Log("エネミー生成エラー");
                    break;

            }
            _geneSpanCount = 0;
        }
    }
}
