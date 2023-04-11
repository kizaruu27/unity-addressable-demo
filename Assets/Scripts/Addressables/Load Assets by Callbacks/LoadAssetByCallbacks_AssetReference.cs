using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadAssetByCallbacks_AssetReference : MonoBehaviour
{
    [SerializeField] private AssetReference assetReference;

    private void Start()
    {
        Addressables.LoadAssetAsync<GameObject>(assetReference).Completed += (asyncOperationHandle) =>
        {
            if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                Instantiate(asyncOperationHandle.Result);
            else
                Debug.Log("Load asset failed");
        };


    }
}
