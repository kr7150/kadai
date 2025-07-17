using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
   [SerializeField] int _playerScore;
    public int hp;
    [SerializeField] float _speed = 5;
    [SerializeField] Text _text;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerScore = PlayerPrefs.GetInt("Score", 0);
        _text.text = "スコア " + _playerScore.ToString();
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * _speed;
        _rb.velocity = move;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Coin coinScript = collision.GetComponent<Coin>();
            _playerScore += coinScript._score;
           Destroy(collision.gameObject);
            _text.text = "スコア " + _playerScore.ToString();
            PlayerPrefs.SetInt("Score" , _playerScore);
        }
    }
}
