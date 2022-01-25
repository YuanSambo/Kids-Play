using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

namespace Game_Difference
{
    public class CardPanel : MonoBehaviour
    {
        public List<GameObject> cards;
        private int _cardCounter = 0;
        private RectTransform _rectTransform;

        private Camera _cam;
        private bool _timeOut;

        private void Awake()
        {
            _cam = Camera.main;
            _rectTransform = GetComponent<RectTransform>();
        }


        private void Update()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (!_timeOut)
                {
                    CheckIfWrong();
                }
            }
        }

        private void CheckIfWrong()
        {
            var mousePosition = Input.GetTouch(0).position;
            var screenPosition = new Vector2(mousePosition.x, mousePosition.y);
            var worldPosition = _cam.ScreenToWorldPoint(screenPosition);

            if (RectTransformUtility.RectangleContainsScreenPoint(_rectTransform, worldPosition))
            {
                GameManager.Instance.WrongAnswer(1, false);
            }
        }

        public void NewSpawnCards()
        {
            StartCoroutine(NewCardCoroutine());
        }

        public void SpawnCards()
        {
            StartCoroutine(SpawnCardsCoroutine());
        }

        private IEnumerator NewCardCoroutine()
        {
            _timeOut = true;
            yield return new WaitForSeconds(2f);
            _timeOut = false;
            StartCoroutine(SpawnCardsCoroutine());
        }

        private IEnumerator SpawnCardsCoroutine()
        {
            _timeOut = true;
            yield return new WaitForSeconds(2f);
            _timeOut = false;
            if (_cardCounter >= cards.Count)
            {
                _cardCounter = 0;
            }

            Instantiate(cards[_cardCounter], cards[_cardCounter].transform.position, Quaternion.identity,
                transform);
            _cardCounter++;
        }
    }
}