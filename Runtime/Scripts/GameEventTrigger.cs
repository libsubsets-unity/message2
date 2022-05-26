using System.Collections;
using UnityEngine;

namespace Subsets.Message2
{
    public class GameEventTrigger : MonoBehaviour
    {
        public GameEvent RaiseEvent;
        public Camera Camera;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    Transform objectHit = hit.transform;
                    Debug.Log("GameEventTrigger" + objectHit.name);
                    if (RaiseEvent)
                    {
                        RaiseEvent.Raise();
                    }
                }
            }

        }
    }
}