using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class LoadSceneAddressable_AdditiveMode : MonoBehaviour
{
    [SerializeField] private AssetReference sceneReference;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Addressables.LoadSceneAsync(sceneReference, LoadSceneMode.Additive).Completed += (asyncOperation) =>
            {
                if (asyncOperation.Status == AsyncOperationStatus.Succeeded)
                    Debug.Log($"Load Scene: {asyncOperation.Result.Scene.name}");
            };
        }
    }
}
