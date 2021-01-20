using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public bool IsShootable { get; private set; }

    public void Hit()
    {
        IsShootable = false;
        _animator.SetTrigger("Hit");
    }

    public void Show()
    {
        StartCoroutine(SetShootableState());
        _animator.SetTrigger("Show");
    }

    private IEnumerator SetShootableState()
    {
        yield return new WaitForSeconds(0.5f);
        IsShootable = true;
    }
}