using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ClueInventoryDisplay : MonoBehaviour
{
    public Player player;
    
    public int X_SPACE_BETWEEN_CLUE;
    public int X_START;
    // Start is called before the first frame update
    void Start()
    {
        GameObject clueBoard = GameObject.Find("ClueInventory");

        if (clueBoard)
        {
            Debug.Log(clueBoard.name + " Found");
            CreateDisplay(clueBoard);
        }
        else { }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDisplay(GameObject board)
    {
        for (int i = 0; i < player.clues.Clues.Count; i++)
        {
            var obj = Instantiate(player.clues.Clues[i].prefab, board.transform.position, Quaternion.identity, transform);

            obj.GetComponent<ClueDisplay>().clue = player.clues.Clues[i];

            obj.name = player.clues.Clues[i].name;

            obj.GetComponent<Transform>().localPosition = GetPosition(i);

            AddEvent(obj, EventTriggerType.PointerClick, delegate { OnClick(obj.GetComponent<BoxCollider>()); });
        }
    }

    public void UpdateDisplay()
    {
        
    }

    public void AddEvent(GameObject obj, EventTriggerType type, UnityAction<BaseEventData> action)
    {
        EventTrigger trigger = obj.GetComponent<EventTrigger>();
        var eventTrigger = new EventTrigger.Entry();
        eventTrigger.eventID = type;
        eventTrigger.callback.AddListener(action);
        trigger.triggers.Add(eventTrigger);
    }

    public void OnClick(BoxCollider collider)
    {
        Debug.Log(collider.gameObject);
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETWEEN_CLUE * i), 0f, 2.6f);
    }
}