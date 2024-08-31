using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObjectSwitcher : MonoBehaviour
{
    public float changeInterval = 2; // 자식 오브젝트 변경 간격

    private Transform[] childObjects;
    private int currentIndex = 0;
    private float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 자식 오브젝트 배열을 초기화합니다.
        int childCount = transform.childCount;
        childObjects = new Transform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            childObjects[i] = transform.GetChild(i);
        }

        // 처음에는 첫 번째 자식을 활성화합니다.
        ActivateChild(0);

    }
    void Update()
    {
        // 밀리초를 초 단위로 변환하여 경과 시간을 증가시킵니다.
        elapsedTime += Time.deltaTime * 1000;

        // 지정된 간격이 지나면 자식 오브젝트를 변경합니다.
        if (elapsedTime >= changeInterval)
        {
            ChangeChild();
            elapsedTime = 0f; // 경과 시간 리셋
        }
    }

        void ChangeChild()
    {
        // 현재 자식 오브젝트를 비활성화합니다.
        childObjects[currentIndex].gameObject.SetActive(false);

        // 다음 자식 오브젝트를 활성화합니다.
        currentIndex = (currentIndex + 1) % childObjects.Length;
        ActivateChild(currentIndex);
    }

    void ActivateChild(int index)
    {
        // 주어진 인덱스의 자식 오브젝트를 활성화합니다.
        childObjects[index].gameObject.SetActive(true);
    }
}