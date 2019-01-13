using UnityEngine;

public class Pplayer : MonoBehaviour
{

    private GameObject currentBullet;
    public GameObject basicBullet;
    public GameObject Bullet2;
    public GameObject destroyedPlayerEffect;
    public GameObject exhaust;
    public GameObject exhaust2;

    public GameObject immortalitySkin;

    public float shootDelay;
    public float exhaustDelay;
    private float shootDelayCounter;
    private float exhaustDelayCounter;

    public GameObject restart;
    public GameObject QuitGame;
    public GameObject MainMenu;
    public static bool lose = false;

    public static bool immortal = false;
    public float immortalityDelay;
    private float immortalityDelayCounter;

    void Start()
    {
        currentBullet = basicBullet;
        shootDelayCounter = 0;
        exhaustDelayCounter = 0;
        immortalityDelayCounter = immortalityDelay;

        if (Ship1.ship1)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Player");
        }
        if (Ship2.ship2)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Player2");
        }
        if (Ship3.ship3)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Player3");
        }
    }

    void Awake()
    {
        lose = false;
    }

    void Update()
    {
        if (lose == false)
        {
            Shoot();
            Exhaust();
            if (immortal == true)
            {
                if (immortalityDelayCounter <= 0)
                {
                    immortal = false;
                    immortalityDelayCounter = immortalityDelay;
                }
                Instantiate(immortalitySkin, transform.position, transform.rotation);
                immortalityDelayCounter -= Time.deltaTime;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Asteroid":
                Death();
                break;
            case "EnemyBullet":
                Death();
                break;
            case "Enemy5":
                Death();
                break;
            case "ImmortalityBonus":
                Immortality();
                break;
        }
    }

    private void Shoot()
    {
        if(shootDelayCounter <= 0)
        {
            if((currentBullet == basicBullet) && FindObjectsOfType<Bullet>().Length < 4)
            {
                Instantiate(currentBullet, new Vector2(transform.position.x, transform.position.y + 0.394f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
            if ((currentBullet == Bullet2) && FindObjectsOfType<Bullet2>().Length < 4)
            {
                Instantiate(currentBullet, new Vector2(transform.position.x, transform.position.y + 0.394f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }

    private void Exhaust()
    {
        if (Ship1.ship1){
            if (exhaustDelayCounter <= 0)
            {
                Instantiate(exhaust, new Vector2(transform.position.x, -3.531f), transform.rotation);
                exhaustDelayCounter = exhaustDelay;
            }
            exhaustDelayCounter -= Time.deltaTime;
        }
        if (Ship2.ship2)
        {
            if (exhaustDelayCounter <= 0)
            {
                Instantiate(exhaust2, new Vector2(transform.position.x, -3.468f), transform.rotation);
                exhaustDelayCounter = exhaustDelay;
            }
            exhaustDelayCounter -= Time.deltaTime;
        }
        if (Ship3.ship3)
        {
            if (exhaustDelayCounter <= 0)
            {
                Instantiate(exhaust2, new Vector2(transform.position.x, -3.44331f), transform.rotation);
                exhaustDelayCounter = exhaustDelay;
            }
            exhaustDelayCounter -= Time.deltaTime;
        }
    }

    public void ChangeWeapon(int type)
    {
        switch (type)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                currentBullet = Bullet2;
                break;
            default:
                break;
        }
    }

    private void Death()
    {
        if (!immortal)
        {
            lose = true;
            if (destroyedPlayerEffect != null)
            {
                Instantiate(destroyedPlayerEffect, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            restart.SetActive(true);
            QuitGame.SetActive(true);
            MainMenu.SetActive(true);
        }
    }

    private void Immortality()
    {
        immortal = true;
    }
}
