using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{
    [SerializeField] GameObject UI_elements;
    [SerializeField] TextMeshProUGUI dialogue_Text;
    [SerializeField] string[] NPCDialogue;
    [SerializeField] NPC_Dialogue NPCDialogueScript;
    int dialogueIndex = 0;
     
    void OnTriggerEnter(Collider col)
    {
        NPCDialogueScript = col.gameObject.GetComponent<NPC_Dialogue>();
        if (NPCDialogueScript)
        {
            UI_elements.SetActive(true);
            NPCDialogue = NPCDialogueScript.data.dialogue;
            ShowNextDialogueLine();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "NPC")
        {
            UI_elements.SetActive(false);
            dialogueIndex = 0;
        }
    }

    public void ShowNextDialogueLine()
    {
        if (dialogueIndex < NPCDialogue.Length)
        {
            dialogue_Text.text = NPCDialogue[dialogueIndex];
            dialogueIndex++;
        }
        else
        {

        }
    }
}
