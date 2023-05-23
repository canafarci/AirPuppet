using PaintIn3D;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static PaintIn3D.P3dReadColor;

public class SpawnColorSphere : MonoBehaviour
{
    //public UnityAction<Color> OnHit;
    public static event Action OnEndGameCollision;
    bool _triggeredEndGame = false;
    private EndGameSprite _sprite;

    private void Awake()
    {
        _sprite = GetComponentInParent<EndGameSprite>();
    }

    //[SerializeField] GameObject _spawnSphere;

    //private void Start()
    //{
    //    if (gameObject.transform.childCount > 1)
    //        _spawnSphere = transform.GetChild(1).transform.gameObject;
    //}


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            //if(_spawnSphere!=null)
            //   {
            //       _spawnSphere.SetActive(true);
            //       AudioConfig config = GameManager.Instance.References.LevelConfig.PaintAudio;
            //       GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
            //   }
            _sprite.EndSprite.SetActive(true);


            if (!_triggeredEndGame)
                StartCoroutine(PopAction());
        }
    }

    IEnumerator PopAction()
    {
        _triggeredEndGame = true;
        yield return new WaitForSeconds(GameManager.Instance.References.LevelConfig.AfterSplashDelay);
        OnEndGameCollision?.Invoke();
    }

}
