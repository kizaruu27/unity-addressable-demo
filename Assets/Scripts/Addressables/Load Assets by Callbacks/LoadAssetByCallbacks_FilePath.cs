using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadAssetByCallbacks_FilePath : MonoBehaviour
{
    [SerializeField] private string filePath;

    private void Start()
    {
        AsyncOperationHandle<GameObject> asyncOperationHandle = Addressables.LoadAssetAsync<GameObject>(filePath);

        asyncOperationHandle.Completed += AsyncOperationHandle_Complete;
    }

    void AsyncOperationHandle_Complete(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded) 
            Instantiate(asyncOperationHandle.Result);
        
        else
            Debug.Log("Load asset failed");
        
    }
}
