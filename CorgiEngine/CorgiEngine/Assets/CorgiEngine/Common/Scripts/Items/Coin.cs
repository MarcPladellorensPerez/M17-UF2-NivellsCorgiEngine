using UnityEngine;
using MoreMountains.CorgiEngine;

namespace MoreMountains.CorgiEngine
{
    /// <summary>
    /// Coin manager
    /// </summary>
    [AddComponentMenu("Corgi Engine/Items/Coin")]
    public class Coin : PickableItem
    {
        public PortalController portalController;

        protected override void Pick(GameObject picker) 
        {
            CorgiEnginePointsEvent.Trigger(PointsMethods.Add, 10); // Añadir puntos al jugador
            portalController.AddCoin(); // Notificar al portal que se ha recogido una moneda
        }
    }
}
