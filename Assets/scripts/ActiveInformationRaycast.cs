using UnityEngine;

public class ActiveInformationRaycast : MonoBehaviour
{
    public LayerMask layermask;
    private Camera myCamera;
    private Touch myTouch;
    public bool onDevice;
    void Start()
    {
        myCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (onDevice)
        {
            if (Input.touchCount != 0)
            {
                myTouch = Input.GetTouch(0);
                if (myTouch.phase == TouchPhase.Began)
                {
                    CheckRaycast(myTouch.position);
                }   
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                CheckRaycast(Input.mousePosition);
            }
        }
    }

    private void CheckRaycast(Vector3 target)
    {
        Ray cameraRay = myCamera.ScreenPointToRay(target);
        RaycastHit hit;
        if (Physics.Raycast(cameraRay, out hit, 500f, layermask))
        {
            print("Choque con: " + hit.collider.gameObject.name);
            Infomation info = hit.collider.GetComponent<Infomation>();
            if (info != null)
            {
                info.ActiveInformation();
            }
        }
    }
}
