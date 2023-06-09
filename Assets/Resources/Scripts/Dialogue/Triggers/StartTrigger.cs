using UnityEngine;

public class StartTrigger : MainTrigger
{
    [SerializeField] private TextAsset _history;
    
    private void Start()
    {
        CallHistory();
    }

    protected override void Call()
    {
        _dialogueController.EnterDialogueMode(_history);
    }
}
