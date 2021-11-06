using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModController : MonoBehaviour
{

    public Text scoreUI;
    public Text hpUI;
    public Text comboUI;
    public RectTransform scrollHpUI;
    public static int currentscore = 0;
    public static int hp = 900;
    public static int combo = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = currentscore.ToString();
        hpUI.text = hp.ToString();
        comboUI.text = combo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scrollNote();
    }



    void scrollNote()
    {
        scoreUI.text = currentscore.ToString();
        comboUI.text = combo.ToString();
        hpUI.text = hp.ToString();
        scrollHpUI.offsetMax = new Vector2(hp, -10);

     

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.gameObject.tag == "Note")
                    {
                        Destroy(hit.collider.gameObject);
                        combo += 1;
                        currentscore += 100 * combo;
                    }
                }
            }
        }
    }





}
