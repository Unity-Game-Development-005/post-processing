
using UnityEngine;

using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class VolumeTest : MonoBehaviour
{
    // reference to the 'Global Volume' componemt
    public Volume globalVolume;

    // reference to the 'Color Adjustments' override section ( if added )
    ColorAdjustments _colAdj;

    // reference to the 'Depth Of Field' override section ( if added )
    DepthOfField _dof;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // try to set the reference to the global volume's color adjustments overrides
        globalVolume.profile.TryGet(out _colAdj);

        // try to set the reference to thw global volume's depth of field overrides
        globalVolume.profile.TryGet(out _dof);
    }


    // Update is called once per frame
    void Update()
    {
        // if we press the 'c' key
        if (Input.GetKeyDown(KeyCode.C))
        {
            // and we have been able to set the reference to the global volume's color adjustments overrides
            if (_colAdj != null)
            {
                // adjust the 'Post Exposure' value
                _colAdj.postExposure.value = 0;
            }

        }

        // if we press the 'f' key
        if (Input.GetKeyDown(KeyCode.F))
        {
            // and we have been able to set the reference to the global volume's depth of field overrides
            if (_dof != null)
            {
                // adjust the 'Aperture' value
                _dof.aperture.value = 10;
            }
        }
    }


} // end of class
