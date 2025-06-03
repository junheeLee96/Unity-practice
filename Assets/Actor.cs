using UnityEngine;

namespace Example
{
    public class Actor
    {
        public int id;
        public string name;
        public int level;
        public string weapon;

        public string Talk()
        {
            return "대화를 걸었습니다";
        }

        public string HasWeapon()
        {
            return weapon;
        }

        public void LevelUp()
        {
            level += 1;
        }
    }
}