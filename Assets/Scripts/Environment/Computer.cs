using Environment.Tasks;
using UnityEngine;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
        [SerializeField]
        private Task testTask = null; // Put your stack/queue here :)
        //comment
        public void OnInteract() {
            testTask.Execute();
        }
    }
}
