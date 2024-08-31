using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObjectSwitcher : MonoBehaviour
{
    public float changeInterval = 2; // �ڽ� ������Ʈ ���� ����

    private Transform[] childObjects;
    private int currentIndex = 0;
    private float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // �ڽ� ������Ʈ �迭�� �ʱ�ȭ�մϴ�.
        int childCount = transform.childCount;
        childObjects = new Transform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            childObjects[i] = transform.GetChild(i);
        }

        // ó������ ù ��° �ڽ��� Ȱ��ȭ�մϴ�.
        ActivateChild(0);

    }
    void Update()
    {
        // �и��ʸ� �� ������ ��ȯ�Ͽ� ��� �ð��� ������ŵ�ϴ�.
        elapsedTime += Time.deltaTime * 1000;

        // ������ ������ ������ �ڽ� ������Ʈ�� �����մϴ�.
        if (elapsedTime >= changeInterval)
        {
            ChangeChild();
            elapsedTime = 0f; // ��� �ð� ����
        }
    }

        void ChangeChild()
    {
        // ���� �ڽ� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
        childObjects[currentIndex].gameObject.SetActive(false);

        // ���� �ڽ� ������Ʈ�� Ȱ��ȭ�մϴ�.
        currentIndex = (currentIndex + 1) % childObjects.Length;
        ActivateChild(currentIndex);
    }

    void ActivateChild(int index)
    {
        // �־��� �ε����� �ڽ� ������Ʈ�� Ȱ��ȭ�մϴ�.
        childObjects[index].gameObject.SetActive(true);
    }
}