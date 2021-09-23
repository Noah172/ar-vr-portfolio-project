using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{

    [field: SerializeField]
    public bool PlayerDetected { get; private set; }
    public Vector2 directionToTarget => target.transform.position - detectorOrigin.position;

    [Header("OverlapBox Parameters")]
    [SerializeField]
    private Transform detectorOrigin;
    public Vector2 detectorSize = Vector2.one;
    public float detectorArea = 3.0f;
    public Vector2 detectorOriginOffset = Vector2.zero;

    public float detectOnDelay = 0.3f;

    public LayerMask detectorLayerMask;

    [Header("Gizmo Parameters")]
    public Color gizmoColor = Color.blue;
    public Color gizmoDetectedColor = Color.red;
    public bool showGizmos = true;

    private GameObject target;

    public GameObject Target
    {
        get => target;
        private set
        {
            target = value;
            PlayerDetected = Target != null;
        }
    }

    private void Start()
    {
        StartCoroutine(DetectionCoroutine());
    }

    IEnumerator DetectionCoroutine()
    {
        yield return new WaitForSeconds(detectOnDelay);
        PerformDetection();
        StartCoroutine(DetectionCoroutine());
    }

    public void PerformDetection()
    {
        Collider2D collider = Physics2D.OverlapBox((Vector2)detectorOrigin.position + detectorOriginOffset, detectorSize, 3, detectorLayerMask);

        if (collider != null)
        {
            Target = collider.gameObject;
        }
        else
        {
            Target = null;
        }
    }

    private void OnDrawGizmos()
    {
        if (showGizmos && detectorOrigin != null)
        {
            Gizmos.color = gizmoColor;
            if (PlayerDetected)
            {
                Gizmos.color = gizmoDetectedColor;
            }
            Gizmos.DrawSphere((Vector2)detectorOrigin.position + detectorOriginOffset, detectorArea);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
