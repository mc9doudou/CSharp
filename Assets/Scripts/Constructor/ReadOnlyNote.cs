using UnityEngine;

namespace Constructor
{
    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            WithService file = new WithService("[1] 파일 로그");
            file.Run();

            WithService db = new WithService("[1] 파일 로그");
            db.Run();

        }


    }
}
