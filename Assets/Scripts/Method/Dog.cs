using UnityEngine;
namespace method
{


    public class Dog
    {
        //필드 선언
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1] 밥을 먹는다");
            Digest();
        }
        
        
        public static void Drink()
        {
            Debug.Log("[2] 물을 마신다");
        }

        private void Digest()
        {
            Debug.Log("[3] 소화를 시킨다");
        }

    }
}