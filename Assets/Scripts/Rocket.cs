using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    
    
    
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
        
        if (fuel == 0f) return;
        else if (fuel >= FUELPERSHOOT)
        {
            _rb2d.AddForce(transform.up * SPEED, ForceMode2D.Impulse); // 힘의 방향, 힘의 크기, 힘의 형태를 매개변수로 가지고 있다.
            fuel -= FUELPERSHOOT;
            
        }
        
        
        
    }
}
