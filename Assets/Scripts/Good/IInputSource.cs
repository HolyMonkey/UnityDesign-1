using UnityEngine;

namespace Good
{
    public interface IMoveDirectionSource
    {
        /// <returns> Normalized direction </returns>
        Vector3 GetDirection();
    }
}
