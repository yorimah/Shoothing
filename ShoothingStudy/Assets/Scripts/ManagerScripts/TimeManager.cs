using UnityEngine;

public class TimeManager
{
    public float time;

    public  void TimeUpdate()
    {
        time += Time.deltaTime;
    }
}
