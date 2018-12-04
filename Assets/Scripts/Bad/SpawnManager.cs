using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bad
{
    public class SpawnManager : MonoBehaviour
    {
        public int chislo;
        public GameObject PREFAB;

        public Transform SP1, SP2, SP3, SP4, SP5;
        public GameObject temp;

        void Start()
        {
            for (int i = 0; i < chislo; i++)
            {
                switch (i)
                {
                    case 0:
                        temp = Instantiate(PREFAB, SP1);
                        temp.GetComponent<PlayerController>().numbar = i + 1;
                        break;
                    case 1:
                        temp = Instantiate(PREFAB, SP2);
                        temp.GetComponent<PlayerController>().numbar = i + 1;
                        break;
                    case 2:
                        temp = Instantiate(PREFAB, SP3);
                        temp.GetComponent<PlayerController>().numbar = i + 1;
                        break;
                    case 3:
                        temp = Instantiate(PREFAB, SP4);
                        temp.GetComponent<PlayerController>().numbar = i + 1;
                        break;
                    case 4:
                        temp = Instantiate(PREFAB, SP5);
                        temp.GetComponent<PlayerController>().numbar = i + 1;
                        break;
                }
            }
        }

        void Update()
        {

        }
    }
}
