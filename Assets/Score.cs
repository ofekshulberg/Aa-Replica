using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        PinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PinCount.ToString();
    }
}
