using PrivatePublic;
using UnityEngine;
namespace PrivatePublic
{
    public class FieldArray : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Schedule schedule = new Schedule();
            schedule.PrintWeekDays();


        }
    }
}