using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]public Rigidbody    PlayerRigid;
    [SerializeField]public Camera       PlayerCamera;
    [SerializeField]public GameObject   Bullet;
    [SerializeField]public GameObject   BulletSpawnPoint;
    [SerializeField]public LayerMask    groundmask;
                    public float AttackSpeed;
                    //public Vector3      BulletSpawn;
                    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine("PlayerControllerAttack");
    }

    void PlayerControllerMovement()
    {
        
    }
        IEnumerator PlayerControllerAttack()
    {
       // BulletSpawn = new Vector3 
        if(Input.GetMouseButtonDown(0))
        {
            
            Instantiate(Bullet,BulletSpawnPoint.transform.position,Quaternion.identity);
            yield return new WaitForSeconds (AttackSpeed);
        }

    }
        public void BulletLogicSystem()
    {
        //Bullet.transform.position = 
        if(Physics.Raycast(PlayerCamera.ScreenPointToRay(Input.mousePosition), out RaycastHit hitlocation,float.MaxValue,groundmask))
        {
            GameObject.FindWithTag("ProjectilePlayer").GetComponent<Transform>().position = hitlocation.point;
        }
        

        
    }
}
