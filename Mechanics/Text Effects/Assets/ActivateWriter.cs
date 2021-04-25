using UnityEngine;
using UnityEngine.UI;

public class ActivateWriter : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("Message").GetComponent<Text>();
    }

    void Start()
    {
        textWriter.AddWriter(messageText, "Not sure what to type but a girl got to try... so here goes!!!" +
            " Once upon a time, there lived a prince on Planet End.", 0.2f, true);
    }

    
}
