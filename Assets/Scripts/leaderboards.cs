using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using UnityEngine.SocialPlatforms;
using Unity.Services.Leaderboards;

public class leaderboards : MonoBehaviour
{
    private async void Awake()
    {
        await UnityServices.InitializeAsync();
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }
}
