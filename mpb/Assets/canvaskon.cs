using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class canvaskon : MonoBehaviour
{
    public TMP_Text hız;
    public TMP_Text zipla;
    private void Start()
    {
        hızgüncelle();
        zıpgüncelle();
      
    }
    public void hızgüncelle()
    {
        hız.text = "HIZ PUANI=" + FindObjectOfType<karakterhar>().speedamount.ToString();
    }
    public void zıpgüncelle()
    {
        zipla.text = "ZIPLAMA PUANI=" + FindObjectOfType<karakterhar>().jumpamount.ToString();
    }

}
