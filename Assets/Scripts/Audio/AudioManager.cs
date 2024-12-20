using Cysharp.Threading.Tasks;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    private AudioClip backgroundMusic; // 背景音乐

    private AudioSource musicSource; // 用于播放背景音乐的 AudioSource
    private AudioSource soundEffectSource; // 用于播放其他音效的 AudioSource
    
    
    public AudioClip die; // 死亡音效
    public AudioClip create; // 创建音效
    public AudioClip win;
    public AudioClip lose;
    private void OnSoundChangeHandler(int value)
    {
        soundEffectSource.volume = value / 100f;
    }
    private void OnMusicChangeHandler(int value)
    {
        musicSource.volume = value / 100f;
    }
    protected override async void Awake()
    {
        base.Awake();
        // 初始化音频源
        musicSource = gameObject.AddComponent<AudioSource>();
        soundEffectSource = gameObject.AddComponent<AudioSource>();
        return;
    }

    // 播放背景音乐
    public void PlayBackgroundMusic(string clipName)
    {
        var clip = ResourceHelper.LoadGameObjectSync<AudioClip>(clipName);
        if (!clip)
            return;
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    // 播放音效
    public void PlaySoundEffect(ClipID id)
    {
        var clip = ResourceHelper.LoadGameObjectSync<AudioClip>(id.ToString());
        if (clip)
            soundEffectSource.PlayOneShot(clip);
    }
    public void PlayCreateSoundEffect()
    {
        soundEffectSource.PlayOneShot(create);
    }
    public void PlayDieSoundEffect()
    {
        soundEffectSource.PlayOneShot(die);
    }
    public void PlayWinSoundEffect()
    {
        soundEffectSource.PlayOneShot(win);
    }
    public void PlayLoseSoundEffect()
    {
        soundEffectSource.PlayOneShot(lose);
    }
    // 停止背景音乐
    public void StopBackgroundMusic()
    {
        musicSource.Stop();
    }
}