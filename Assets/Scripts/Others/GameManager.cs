using System.Collections;
using Others;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    // TODO Rewards Panel
    public GameObject RewardPanel;
    public int rounds = 3;

    private int _correctAnswer;
    private int _currentRound;

    private SceneData _sceneData;
    private RewardsData _rewardsData;

    private void Awake()
    {
        var sceneName = SceneManager.GetActiveScene().name;

        _sceneData = SceneDataHandler.LoadSceneData(sceneName);
        _rewardsData = StickerDataHandler.LoadStickerData();


        _sceneData.Plays++;
        _sceneData.PlayTime.Add(0);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField] private UnityEvent onStart;

    private void Start()
    {
        onStart?.Invoke();
    }

    protected void Update()
    {
        if (_correctAnswer >= rounds)
        {
            RoundWin();
        }

        if (_currentRound >= 7)
        {
            ShowReward();
            _currentRound = 0;
        }


        _sceneData.PlayTime[_sceneData.Plays - 1] = (int)Time.timeSinceLevelLoad;
        SceneDataHandler.SaveSceneData(_sceneData);
    }

    [SerializeField] private UnityEvent onCorrectAnswer;

    public void CorrectAnswer()
    {
        _sceneData.Correct++;
        _correctAnswer++;
        SoundManager.Instance.Play("Sparkle");
        onCorrectAnswer?.Invoke();
    }


    [SerializeField] private UnityEvent onWrongAnswer;

    public void WrongAnswer(int count = 1)
    {
        _sceneData.Wrong+=count;
        onWrongAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onRoundWin;

    private void RoundWin()
    {
        _currentRound++;
        SoundManager.Instance.Play("Yey");
        SoundManager.Instance.PlayWithDelay("GreatJob", 0.5f);
        Reset();

        onRoundWin?.Invoke();
    }

    private void Reset()
    {
        _correctAnswer = 0;
    }

    private void ShowReward()
    {
        if (_rewardsData.lockedSticker.Count <= 0)
        {
            return;
        }

        StartCoroutine(ShowRewardCoroutine());
    }

    private IEnumerator ShowRewardCoroutine()
    {
        StickerDataHandler.UnlockRandomSticker(_rewardsData);
        yield return new WaitForSeconds(2f);
        RewardPanel.SetActive(true);
        Time.timeScale = 0;
    }
}