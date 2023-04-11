using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class LoadSceneAddressable_SingleMode : MonoBehaviour
{
    [SerializeField] private AssetReference sceneReference;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Addressables.LoadSceneAsync(sceneReference, LoadSceneMode.Single).Completed += (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                    Debug.Log($"Load Scene: {asyncOperationHandle.Result.Scene.name}");
            };
        }
    }
}
