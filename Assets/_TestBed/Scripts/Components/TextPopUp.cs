using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace Oculus.Interaction
{
    public class TextPopUp : MonoBehaviour
    {
        [SerializeField, Interface(typeof(IInteractableView))]
        private MonoBehaviour _interactableView;

        private IInteractableView InteractableView;

        protected bool _started = false;
        protected bool _on = false;

        protected virtual void Awake()
        {
            InteractableView = _interactableView as IInteractable;
        }

        protected virtual void Start()
        {
            this.BeginStart(ref _started);
            Assert.IsNotNull(InteractableView);


            this.EndStart(ref _started);
        }

        protected virtual void OnEnable()
        {
            if (_started)
            {
                UpdateVisual();
                InteractableView.WhenStateChanged += UpdateVisualState;
            }
        }

        protected virtual void OnDisable()
        {
            if (_started)
            {
                InteractableView.WhenStateChanged -= UpdateVisualState;
            }
        }

        protected virtual void UpdateVisual()
        {
            switch (InteractableView.State)
            {
                case InteractableState.Hover:
                    PopUpTextOn();
                    break;
                default:
                    PopUpTextOff();
                    break;
            }
        }

        private void UpdateVisualState(InteractableStateChangeArgs args) => UpdateVisual();

        private void PopUpTextOn()
        {
            Debug.LogWarning("Pop up text has turned on");
        }

        private void PopUpTextOff()
        {
            Debug.LogWarning ("Pop up text is off");
        }
    }
}
