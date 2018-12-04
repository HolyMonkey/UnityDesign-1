using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Bad
{
    public class PlayerController : MonoBehaviour
    {
        public int _Money;
        public int _health = 2;
        public int numbar;

        private void Start()
        {

        }

        void Update()
        {
            GameObject.Find("Canvas").transform.Find("Money" + numbar).GetComponent<Text>().text = _Money.ToString(); 
            GameObject.Find("Canvas").transform.Find("Health" + numbar).GetComponent<Text>().text = _health.ToString();

            if(_health <= 0)
            {
                Destroy(gameObject);
            }

            switch (numbar)
            {
                case 1:
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime);
                    break;
                case 2:
                    transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * Time.deltaTime);
                    break;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("Money"))
            {
                Destroy(collision.gameObject);
                _Money++;
            }
            else if(collision.name.Contains("Бомба"))
            {
                _health--;
                Destroy(collision.gameObject);
            }
        }
    }
}
