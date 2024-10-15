using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    GameObject rocket;
    
    
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
        if(fuel == 0f)return;
        else if(fuel > 10f)
        {
           _rb2d.AddForce(Vector2.up *  SPEED);
            fuel -= FUELPERSHOOT;
        }
    }
}
