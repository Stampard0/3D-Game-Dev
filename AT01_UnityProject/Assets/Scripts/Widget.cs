using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Widget : MonoBehaviour
{
    [SerializeField] private Image[] icons;

    private float flashTimer = -1;
    private Player player;

    private void Awake()
    {
        FindObjectOfType<Enemy>().GameOverEvent += delegate
        {
            gameObject.SetActive(false);
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.Instance.Player;
        player.InputDirection += MovementInput; //subscribe to player input event
        for(int i = 0; i < icons.Length; i++) //setting icons to default colour
        {
            icons[i].color = Color.gray;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(flashTimer >= 0)
        {
            flashTimer += Time.deltaTime;
            if(flashTimer > 0.1f)
            {
                flashTimer = -1;
                for (int i = 0; i < icons.Length; i++) //setting icons to default colour
                {
                    icons[i].color = Color.gray;
                }
            }
        }
    }

    public void MovementInput(char c)
    {
        flashTimer = 0;
        switch (c)
        {
            case 'u':
                if (player.CurrentNode.Parents.Length > 0 && player.CurrentNode.Parents[0].Parents.Length > 0)
                {
                    player.MoveToNode(player.CurrentNode.Parents[0]); //move player to parent of current node
                    icons[0].color = Color.green;
                }
                else
                {
                    icons[0].color = Color.red;
                }
                break;
            case 'd':
                if (player.CurrentNode.Children.Length > 0)
                {
                    player.MoveToNode(player.CurrentNode.Children[0]); //move player to first child
                    icons[1].color = Color.green;
                }
                else
                {
                    icons[1].color = Color.red;
                }
                break;
            case 'r':
                if (player.CurrentNode.Parents.Length > 0)
                {
                    foreach (Node node in player.CurrentNode.Parents[0].Children)
                    {
                        if (node.transform.position.x == player.CurrentNode.transform.position.x + 10)
                        {
                            player.MoveToNode(node); //move player to node
                            icons[2].color = Color.green;
                            return;
                        }
                    }
                }
                icons[2].color = Color.red;
                break;
            case 'l':
                if(player.CurrentNode.Parents.Length > 0)
                {
                    foreach(Node node in player.CurrentNode.Parents[0].Children)
                    {
                        if(node.transform.position.x == player.CurrentNode.transform.position.x - 10)
                        {
                            player.MoveToNode(node); //move player to node
                            icons[3].color = Color.green;
                            return;
                        }
                    }
                }
                icons[3].color= Color.red;
                break;
        }
    }
}
