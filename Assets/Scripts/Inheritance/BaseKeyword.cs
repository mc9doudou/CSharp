using UnityEngine;
namespace Inheritance05
{


    public class BaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            (new My()).Run();
            (new My("아반테")).Run();


        }
    }
}