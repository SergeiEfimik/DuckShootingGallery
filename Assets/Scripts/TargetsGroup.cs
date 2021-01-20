using UnityEngine;

public class TargetsGroup : MonoBehaviour
{
    private Target[] _targets;

    private void Start()
    {
        _targets = GetComponentsInChildren<Target>();
    }

    public void ShowRandomTarget()
    {
        int i = Random.Range(0, _targets.Length);

        if (_targets[i].IsShootable == false)
        {
            _targets[i].Show();
        }        
    }
}