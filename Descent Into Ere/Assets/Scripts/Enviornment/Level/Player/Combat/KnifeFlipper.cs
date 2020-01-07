using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeFlipper : MonoBehaviour
{
    //Left and right facing knives
    public GameObject knifeLeft;
    public GameObject knifeRight;
    public GameObject steakKnifeLeft;
    public GameObject steakKnifeRight;

    /* On start, since the player will be facing right,
     * the left facing knife is disabled,
     * and the right facing knife is enabled
     */
    void Start()
    {
        knifeRight.SetActive(true);
        knifeLeft.SetActive(false);
    }

    /* If the player is facing left,
     * the left facing knfie is enabled, and the right facing knife is disabled
     * If the player is no longer facing left,
     * the left facing knife is disabled, and the right facing knife is enabled
     */
    void Update()
    {
        if(Flipper.facingLeft == true)
        {
            knifeRight.SetActive(false);
            knifeLeft.SetActive(true);
        }
        else
        {
            knifeRight.SetActive(true);
            knifeLeft.SetActive(false);
        }
    }
}
