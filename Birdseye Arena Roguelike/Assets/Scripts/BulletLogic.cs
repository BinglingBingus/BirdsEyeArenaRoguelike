using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    [SerializeField] Camera MainCameraPlayer;
    [SerializeField] LayerMask GroundMask;
    [SerializeField] Transform PlayerGO;
    
    Transform Bullet;
    Transform BulletTargetPos;
    Vector3 BulletTarget;
    

    // Start is called before the first frame update
    void Start()
    {
        //Bullet.position = Input.mousePosition;
        //MainCameraPlayer.FindObjectOfType(Camera);
        PlayerController PC = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

            PC.BulletLogicSystem();
            Debug.Log("im here");
  

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    }
   // IEnumerator BulletLogicSystem()
    //{

        
    //}

