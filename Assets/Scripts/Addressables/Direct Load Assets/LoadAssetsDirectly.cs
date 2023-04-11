using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAssetsDirectly : MonoBehaviour
{
    [SerializeField] private AssetReference assetReference;
    
    void Start()
    {
        Addressables.InstantiateAsync(assetReference);
    }
}
