using UnityEngine;
using DG.Tweening;

public class JumpExample : MonoBehaviour
{
    void Start()
    {
        transform.DOJump(new Vector3(-12.5f,-2.5f,0), 0.5f, 1, 3f);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player"))
        {
//            GameManager.Instance.AddCollecible();
            transform.DOJump(new Vector3(-12.5f,-2.5f,0), 0.5f, 1, 3f);
        }        
    }
}
