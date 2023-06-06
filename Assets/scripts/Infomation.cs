using UnityEngine;
public class Infomation : MonoBehaviour
{
      public GameObject information;

      public void ActiveInformation()
      {
            information.SetActive(!information.activeSelf);
      }
}
