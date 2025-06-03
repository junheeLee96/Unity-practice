using System;
using UnityEngine;
using System.Collections.Generic;

namespace Example
{
    public class ex : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Hello Unity");
            int level = 5;
            float strength = 15.5f;
            string playerName = "Lee";
            bool isFullLevel = false;
            int health = 100;
            
            Debug.Log(level);
            Debug.Log(strength);
            Debug.Log(playerName);
            Debug.Log(isFullLevel);

            string[] monsters = {"슬라임", "사막뱀", "악마"};
            int[] monstersLevel = new int[3];
            monstersLevel[0] = 1;
            monstersLevel[1] = 2;
            monstersLevel[2] = 2;
            Debug.Log(monsters);
            Debug.Log(monstersLevel);

            List<string> items = new List<string>();
            items.Add("생명의 물약30");
            items.Add("마나의 물약30");
            
            Debug.Log(items);

            items.RemoveAt(0);
            health = Math.Min(100, Heal(health));
            Debug.Log(health);

            Actor player = new Actor();
            player.id = 0;
            player.level = 10;
            player.weapon = "no";
            
            Debug.Log(player);
            
        }

        int Heal(int health)
        {
            health += 10;

            return health;
        }
    }
}