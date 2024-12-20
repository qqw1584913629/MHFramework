using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class MUIHelepr
{
    public static Transform FindDeepChild(GameObject _target, string _childName)
    {
        Transform resultTrs = null;
        resultTrs = _target.transform.Find(_childName);
        if (resultTrs == null)
        {
            foreach (Transform trs in _target.transform)
            {
                resultTrs = FindDeepChild(trs.gameObject, _childName);
                if (resultTrs != null)
                    return resultTrs;
            }
        }
        return resultTrs;
    }
    public static T FindDeepChild<T>(GameObject _target, string _childName) where T : Component
    {
        Transform resultTrs = FindDeepChild(_target, _childName);
        if (resultTrs != null)
            return resultTrs.gameObject.GetComponent<T>();
        return (T)((object)null);
    }
    public static void SetText(this Text Label, string content )
        {
            if (null == Label)
            {
                Debug.LogError("label is null");
                return;
            }
            Label.text = content;
        }
        
        public static void SetVisibleWithScale(this UIBehaviour uiBehaviour, bool isVisible)
        {
            if (null == uiBehaviour)
            {
                Debug.LogError("uibehaviour is null!");
                return;
            }

            if (null == uiBehaviour.gameObject)
            {
                Debug.LogError("uiBehaviour gameObject is null!");
                return;
            }
            
            if (uiBehaviour.gameObject.activeSelf == isVisible)
            {
                return;
            }
            uiBehaviour.transform.localScale = isVisible ? Vector3.one : Vector3.zero;
        }
        
        public static void SetVisible(this UIBehaviour uiBehaviour, bool isVisible)
        {
            if (null == uiBehaviour)
            {
                Debug.LogError("uibehaviour is null!");
                return;
            }

            if (null == uiBehaviour.gameObject)
            {
                Debug.LogError("uiBehaviour gameObject is null!");
                return;
            }
            
            if (uiBehaviour.gameObject.activeSelf == isVisible)
            {
                return;
            }
            uiBehaviour.gameObject.SetActive(isVisible);
        }
        public static void SetVisibleWithScale(this Transform transform, bool isVisible)
        {
            if (null == transform)
            {
                Debug.LogError("uibehaviour is null!");
                return;
            }

            if (null == transform.gameObject)
            {
                Debug.LogError("uiBehaviour gameObject is null!");
                return;
            }
            
            transform.localScale = isVisible ? Vector3.one : Vector3.zero;
        }
        
        public static void SetVisible(this Transform transform, bool isVisible)
        {
            if (null == transform)
            {
                Debug.LogError("uibehaviour is null!");
                return;
            }

            if (null == transform.gameObject)
            {
                Debug.LogError("uiBehaviour gameObject is null!");
                return;
            }
            
            if (transform.gameObject.activeSelf == isVisible)
            {
                return;
            }
            transform.gameObject.SetActive(isVisible);
        }


        public  static void SetTogglesInteractable(this ToggleGroup toggleGroup, bool isEnable)
        {
           var toggles = toggleGroup.transform.GetComponentsInChildren<Toggle>();
           for (int i = 0; i < toggles.Length; i++)
           {
               toggles[i].interactable = isEnable;
           }
        }
        

        public static (int,Toggle) GetSelectedToggle(this ToggleGroup toggleGroup)
        {
            var togglesList = toggleGroup.GetComponentsInChildren<Toggle>();
            for (int i = 0; i < togglesList.Length; i++)
            {
                if (togglesList[i].isOn)
                {
                    return (i,togglesList[i]);
                }
            }
            return (-1,null);
        }
        
        
        public static void SetToggleSelected(this ToggleGroup toggleGroup, int index)
        {
            var togglesList = toggleGroup.GetComponentsInChildren<Toggle>();
            for (int i = 0; i < togglesList.Length; i++)
            {
                if (i != index)
                {
                    continue;
                }
                togglesList[i].IsSelected(true);
            }
        }

        public static void IsSelected(this Toggle toggle, bool isSelected)
        {
            toggle.isOn = isSelected;
            toggle.onValueChanged?.Invoke(isSelected);
        }
        

        
  #region UI按钮事件
  
  // public static void AddListenerAsync(this Slider button, Func<float, Task> action)
  // { 
  //     button.onValueChanged.RemoveAllListeners();
  //     async Task clickActionAsync(float value)
  //     {
  //         await action(value);
  //     }
  //     button.onValueChanged.AddListener((float value) =>
  //     {
  //         clickActionAsync(value);
  //     });
  // }
  
  public static void AddListener(this Toggle toggle, UnityAction<bool> selectEventHandler)
        {
            toggle.onValueChanged.RemoveAllListeners();
            
            toggle.onValueChanged.AddListener(selectEventHandler);
        }
        
        public static void AddListener(this Button button,UnityAction clickEventHandler )
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(()=>
            {
                AudioManager.Instance.PlaySoundEffect(ClipID.ButtonClickClip);
            });
            button.onClick.AddListener(clickEventHandler);
        }
        private static bool IsClicked = false;
        public static void AddListenerAsync(this Button button, Func<UniTask> action)
        { 
            button.onClick.RemoveAllListeners();

            async UniTask ClickActionAsync()
            {
                IsClicked = true;
                await action();
                IsClicked = false;
            }
               
            button.onClick.AddListener(() =>
            {
                if (IsClicked)
                    return;
                ClickActionAsync().ToCoroutine();
            });
        }
        public static void AddListenerWithId(this Button button,Action<int> clickEventHandler ,int id)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => { clickEventHandler(id);  });
        }
        
        public static void AddListenerWithId(this Button button,Action<long> clickEventHandler ,long id)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => { clickEventHandler(id);  });
        }

        public static void AddListenerWithParam<T>(this Button button, Action<T> clickEventHandler, T param)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => { clickEventHandler(param);  });
        }
        
        public static void AddListenerWithParam<T,A>(this Button button, Action<T,A> clickEventHandler, T param1 , A param2)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => { clickEventHandler(param1 , param2);  });
        }


       public static void AddListener(this ToggleGroup toggleGroup, UnityAction<int> selectEventHandler)
       {
           var togglesList = toggleGroup.GetComponentsInChildren<Toggle>();
           for (int i = 0; i < togglesList.Length; i++)
           {
               int index = i;
               togglesList[i].AddListener((isOn) => 
               {
                   if (isOn)
                   {
                       selectEventHandler(index);
                   }
               });
           }
       }
       public static void RegisterEvent(this EventTrigger trigger, EventTriggerType eventType, UnityAction<BaseEventData> callback)
        {
            EventTrigger.Entry entry = null;

            // 查找是否已经存在要注册的事件
            foreach (EventTrigger.Entry existingEntry in trigger.triggers)
            {
                if (existingEntry.eventID == eventType)
                {
                    entry = existingEntry;
                    break;
                }
            }
            
            // 如果这个事件不存在，就创建新的实例
            if (entry == null)
            {
                entry = new EventTrigger.Entry();
                entry.eventID = eventType;
            }
            // 添加触发回调并注册事件
            entry.callback.AddListener(callback);
            trigger.triggers.Add(entry);
        }


        #endregion
     
}
