using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTest : MonoBehaviour
{
    [SerializeField]
    private DialogueSystem dialogueSystem;
    private IEnumerator Start()
    {
        yield return new WaitUntil(() => dialogueSystem.UpdateDialogue(0, true));
    }
}
