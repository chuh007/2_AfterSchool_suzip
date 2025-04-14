using UnityEngine;

namespace _100_Script._10_Character
{
    public class Pc : MonoBehaviour
    {
        public Animator Animator;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Animator.Play("Run");
            }
        }
    }
}
