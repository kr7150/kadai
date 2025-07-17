using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : enemybace
{
    [SerializeField] int _speed;
    [SerializeField] GameObject _player;
    // Start is called before the first frame update
    public override void Activate()
    {
            AudioSource audioSource = _player.GetComponent<AudioSource>();
            audioSource.Play();
    }
}
