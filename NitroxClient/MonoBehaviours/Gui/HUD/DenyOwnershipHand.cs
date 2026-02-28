using UnityEngine;

namespace NitroxClient.MonoBehaviours.Gui.HUD;

public sealed class DenyOwnershipHand : MonoBehaviour
{
    private void Start()
    {
        // Forces the message to go away after a few seconds.
        Destroy(this, 2);
    }

    private static void Update()
    {
        //TODO: Check if this should be Hand
        HandReticle.main.SetText(HandReticle.TextType.Hand, "Nitrox_DenyOwnershipHand", true);
        HandReticle.main.SetText(HandReticle.TextType.HandSubscript, string.Empty, false);
        HandReticle.main.SetIcon(HandReticle.IconType.HandDeny);
    }
}
