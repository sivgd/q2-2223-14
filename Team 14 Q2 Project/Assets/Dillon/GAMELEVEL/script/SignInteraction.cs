using UnityEngine;
using UnityEngine.UI;

public class SignInteraction : MonoBehaviour
{
    public GameObject signImage;
    public KeyCode backKey = KeyCode.Escape;

    private bool isImageDisplayed = false;

    private void Update()
    {
        if (isImageDisplayed && Input.GetKeyDown(backKey))
        {
            signImage.SetActive(false);
            isImageDisplayed = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            signImage.SetActive(true);
            isImageDisplayed = true;
        }
    }
}